namespace WinHash
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1_hash = new System.Windows.Forms.Label();
            this.textBox_text = new System.Windows.Forms.TextBox();
            this.label_nt = new System.Windows.Forms.Label();
            this.textBox_NT = new System.Windows.Forms.TextBox();
            this.button_compute = new System.Windows.Forms.Button();
            this.textBox_LM = new System.Windows.Forms.TextBox();
            this.label_lmhash = new System.Windows.Forms.Label();
            this.button_noDash = new System.Windows.Forms.Button();
            this.button_lowerCase = new System.Windows.Forms.Button();
            this.textBox_pwdump = new System.Windows.Forms.TextBox();
            this.label1_pwdump = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_hash
            // 
            this.label1_hash.AutoSize = true;
            this.label1_hash.Location = new System.Drawing.Point(16, 31);
            this.label1_hash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_hash.Name = "label1_hash";
            this.label1_hash.Size = new System.Drawing.Size(103, 20);
            this.label1_hash.TabIndex = 0;
            this.label1_hash.Text = "Text to Hash:";
            // 
            // textBox_text
            // 
            this.textBox_text.Location = new System.Drawing.Point(131, 28);
            this.textBox_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_text.Size = new System.Drawing.Size(644, 26);
            this.textBox_text.TabIndex = 1;
            // 
            // label_nt
            // 
            this.label_nt.AutoSize = true;
            this.label_nt.Location = new System.Drawing.Point(21, 140);
            this.label_nt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nt.Name = "label_nt";
            this.label_nt.Size = new System.Drawing.Size(97, 20);
            this.label_nt.TabIndex = 2;
            this.label_nt.Text = "NTLM Hash:";
            // 
            // textBox_NT
            // 
            this.textBox_NT.Location = new System.Drawing.Point(131, 137);
            this.textBox_NT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_NT.Name = "textBox_NT";
            this.textBox_NT.ReadOnly = true;
            this.textBox_NT.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_NT.Size = new System.Drawing.Size(644, 26);
            this.textBox_NT.TabIndex = 3;
            // 
            // button_compute
            // 
            this.button_compute.Location = new System.Drawing.Point(195, 235);
            this.button_compute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_compute.Name = "button_compute";
            this.button_compute.Size = new System.Drawing.Size(112, 35);
            this.button_compute.TabIndex = 4;
            this.button_compute.Text = "Compute";
            this.button_compute.UseVisualStyleBackColor = true;
            this.button_compute.Click += new System.EventHandler(this.button_compute_Click);
            // 
            // textBox_LM
            // 
            this.textBox_LM.Location = new System.Drawing.Point(131, 84);
            this.textBox_LM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_LM.Name = "textBox_LM";
            this.textBox_LM.ReadOnly = true;
            this.textBox_LM.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_LM.Size = new System.Drawing.Size(644, 26);
            this.textBox_LM.TabIndex = 6;
            // 
            // label_lmhash
            // 
            this.label_lmhash.AutoSize = true;
            this.label_lmhash.Location = new System.Drawing.Point(41, 86);
            this.label_lmhash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lmhash.Name = "label_lmhash";
            this.label_lmhash.Size = new System.Drawing.Size(77, 20);
            this.label_lmhash.TabIndex = 5;
            this.label_lmhash.Text = "LM Hash:";
            // 
            // button_noDash
            // 
            this.button_noDash.Location = new System.Drawing.Point(315, 235);
            this.button_noDash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_noDash.Name = "button_noDash";
            this.button_noDash.Size = new System.Drawing.Size(157, 35);
            this.button_noDash.TabIndex = 7;
            this.button_noDash.Text = "Remove Dash";
            this.button_noDash.UseVisualStyleBackColor = true;
            this.button_noDash.Click += new System.EventHandler(this.button_noDash_Click);
            // 
            // button_lowerCase
            // 
            this.button_lowerCase.Location = new System.Drawing.Point(480, 235);
            this.button_lowerCase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_lowerCase.Name = "button_lowerCase";
            this.button_lowerCase.Size = new System.Drawing.Size(157, 35);
            this.button_lowerCase.TabIndex = 8;
            this.button_lowerCase.Text = "Lower Case";
            this.button_lowerCase.UseVisualStyleBackColor = true;
            this.button_lowerCase.Click += new System.EventHandler(this.button_lowerCase_Click);
            // 
            // textBox_pwdump
            // 
            this.textBox_pwdump.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pwdump.Location = new System.Drawing.Point(131, 189);
            this.textBox_pwdump.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_pwdump.Name = "textBox_pwdump";
            this.textBox_pwdump.ReadOnly = true;
            this.textBox_pwdump.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_pwdump.Size = new System.Drawing.Size(644, 22);
            this.textBox_pwdump.TabIndex = 10;
            // 
            // label1_pwdump
            // 
            this.label1_pwdump.AutoSize = true;
            this.label1_pwdump.Location = new System.Drawing.Point(33, 190);
            this.label1_pwdump.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_pwdump.Name = "label1_pwdump";
            this.label1_pwdump.Size = new System.Drawing.Size(85, 20);
            this.label1_pwdump.TabIndex = 9;
            this.label1_pwdump.Text = "PWDUMP:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 286);
            this.Controls.Add(this.textBox_pwdump);
            this.Controls.Add(this.label1_pwdump);
            this.Controls.Add(this.button_lowerCase);
            this.Controls.Add(this.button_noDash);
            this.Controls.Add(this.textBox_LM);
            this.Controls.Add(this.label_lmhash);
            this.Controls.Add(this.button_compute);
            this.Controls.Add(this.textBox_NT);
            this.Controls.Add(this.label_nt);
            this.Controls.Add(this.textBox_text);
            this.Controls.Add(this.label1_hash);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "WinHash";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.credits_00);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_hash;
        private System.Windows.Forms.TextBox textBox_text;
        private System.Windows.Forms.Label label_nt;
        private System.Windows.Forms.TextBox textBox_NT;
        private System.Windows.Forms.Button button_compute;
        private System.Windows.Forms.TextBox textBox_LM;
        private System.Windows.Forms.Label label_lmhash;
        private System.Windows.Forms.Button button_noDash;
        private System.Windows.Forms.Button button_lowerCase;
        private System.Windows.Forms.TextBox textBox_pwdump;
        private System.Windows.Forms.Label label1_pwdump;
    }
}

