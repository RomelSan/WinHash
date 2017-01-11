using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinHash
{
    /**
        * WinHash - LM and NTLM hash generator. - by Romel Vera C.
        * Computer Expert
        * January 11, 2017
        * MIT License
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string GetUnicodeString(string s)
        {
            /*
             With NTLM, each of the characters in the input password are converted into Unicode 
             (16-bits characters representation – for example an ‘a’ is 0x61 in ASCII, so it’s representation in Unicode is 0x0061.
             It uses a Little Endian format for the data, so the "hello" is stored as:

                h\0 e\0 l\o \l\0 e\0

             where \0 is 0x00. We then just create the Unicode Little Endian format, and take an MD4 hash. 
             In C# this is how we convert the password into a Unicode Little Endian format:
             */
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                sb.Append((char)c);

                sb.Append((char)0);

            }
            return sb.ToString();
        }

        string convert_NTLM(string ntlm)
        {
            /*
             An MD4 signature is then taken of this string, and which results in 128-bit code. 
             While a vast improvement on the horrible LM hash, there was no place for a salt value, 
             so once an intruder knew the mapping between the hashed value and the original password, 
             they would easily map them. If you are interested, here is MD2 and MD4 [MD4]

            When you go this link, select "Unicode Little Endian format" and, for "hello", you should get:

            066DDFD4EF0E9CD7C256FE77191EF43C
             */
            Org.BouncyCastle.Crypto.Digests.MD4Digest md = new Org.BouncyCastle.Crypto.Digests.MD4Digest();

            byte[] unicodePassword = Encoding.Convert(Encoding.ASCII, Encoding.Unicode, Encoding.ASCII.GetBytes(ntlm));

            md.BlockUpdate(unicodePassword, 0, unicodePassword.Length);
            byte[] hash = new byte[16];
            md.DoFinal(hash, 0);
            return ntlm = BitConverter.ToString(hash);

            /*
                 * We can check these with a Python script:

                    import passlib.hash;
                    string= "hello"
                    print "LM Hash:" + passlib.hash.lmhash.encrypt(string)
                    print "NT Hash:" + passlib.hash.nthash.encrypt(string)

                    which gives:

                    LM Hash:fda95fbeca288d44aad3b435b51404ee
                    NT Hash:066ddfd4ef0e9cd7c256fe77191ef43c
            */
        }

        string convert_LM(string lm)
        {
            string lm_result = "";
            byte[] hash = LMHash.Compute(lm);

            foreach (byte s in hash)
            {
                lm_result = BitConverter.ToString(hash);
            }
            return lm_result;
        }

        private void button_compute_Click(object sender, EventArgs e)
        {
            // Get input text as string
            string text_toHash = textBox_text.Text;

            // Solve NTLM
            try
            {
                string text_ntlm = convert_NTLM(text_toHash);
                textBox_NT.Text = text_ntlm;
            }

            catch (Exception ex)
            {
                textBox_NT.Text = ex.Message;
            }

            // Solve LM
            try
            {
                string solved_LM = convert_LM(text_toHash);
                textBox_LM.Text = solved_LM;
            }
            catch (NotSupportedException excep1)
            {
                string error = excep1.Message;
                textBox_LM.Text = error;
            }

            //PWDUMP FORMAT
            // user: 500:LM HASH:NTLM HASH:::
            // LM Hash: "AAD3B435B51404EEAAD3B435B51404EE" is an empty password or not supported
            string pw_text1 = textBox_LM.Text.Replace("-", "");
            string pw_text2 = textBox_NT.Text.Replace("-", "");
            string pw_hash_LM = pw_text1;
            string pw_hash_NTLM = pw_text2;
            if (pw_text1 == "Passwords greater than 14 characters are not supported") { pw_hash_LM = "AAD3B435B51404EEAAD3B435B51404EE"; }
            if (pw_text1 == "Password halves greater than 7 characters are not supported") { pw_hash_LM = "AAD3B435B51404EEAAD3B435B51404EE"; }
            textBox_pwdump.Text = @"user:500:" + pw_hash_LM + @":" + pw_hash_NTLM + @":::";
        }

        private void button_noDash_Click(object sender, EventArgs e)
        {
            textBox_LM.Text = textBox_LM.Text.Replace("-","");
            textBox_NT.Text = textBox_NT.Text.Replace("-", "");
        }

        private void button_lowerCase_Click(object sender, EventArgs e)
        {
            textBox_LM.Text = textBox_LM.Text.ToLower();
            textBox_NT.Text = textBox_NT.Text.ToLower();
            textBox_pwdump.Text = textBox_pwdump.Text.ToLower();
        }
        private void credits_00(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.F5)
            {
                MessageBox.Show("By Romel Vera Cadena", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
