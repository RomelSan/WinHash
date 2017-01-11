using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace WinHash
{
    public static class LMHash
    {
        public static byte[] ComputeHalf(byte[] Half)
        {

            if (Half.Length == 0)
                return new byte[] { 0xAA, 0xD3, 0xB4, 0x35, 0xB5, 0x14, 0x04, 0xEE };
            else if (Half.Length > 7)
                throw new NotSupportedException("Password halves greater than 7 " +
                "characters are not supported");

            Array.Resize(ref Half, 7);

            StringBuilder binaryString = new StringBuilder();

            foreach (char c in Half)
            {
                string s = Convert.ToString(c, 2);

                int padLen = 8 - s.Length;

                binaryString.Append(new string('0', padLen) + s);
            }

            for (int y = 8; y > 0; y--)
                binaryString.Insert(y * 7, '0');

            string binary = binaryString.ToString();

            byte[] key = new byte[8];

            for (int y = 0; y < 8; y++)
                key[y] = Convert.ToByte(binary.Substring(y * 8, 8), 2);

            DESCryptoServiceProvider des = new DESCryptoServiceProvider();

            des.Key = key;
            des.IV = new byte[8];

            using (MemoryStream stream = new MemoryStream())
            {
                using (CryptoStream cryptStream = new CryptoStream(stream,
                des.CreateEncryptor(), CryptoStreamMode.Write))
                using (StreamWriter writer = new StreamWriter(cryptStream))
                    writer.Write("KGS!@#$%");

                byte[] b = stream.ToArray();

                Array.Resize(ref b, 8);

                return b;
            }
        }

        public static byte[] Compute(string Password)
        {
            if (Password.Length > 14)
            throw new NotSupportedException("Passwords greater than 14 " +
            "characters are not supported");

            byte[] passBytes = Encoding.ASCII.GetBytes(Password.ToUpper());

            byte[][] passHalves = new byte[2][];

            if (passBytes.Length > 7)
            {
                int len = passBytes.Length - 7;

                passHalves[0] = new byte[7];
                passHalves[1] = new byte[len];

                Array.Copy(passBytes, passHalves[0], 7);
                Array.Copy(passBytes, 7, passHalves[1], 0, len);
            }
            else
            {
                passHalves[0] = passBytes;
                passHalves[1] = new byte[0];
            }

            for (int x = 0; x < 2; x++)
                passHalves[x] = ComputeHalf(passHalves[x]);

            byte[] hash = new byte[16];

            Array.Copy(passHalves[0], hash, 8);
            Array.Copy(passHalves[1], 0, hash, 8, 8);

            return hash;
        }
    }
}
