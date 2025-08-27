namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.LblForgotUser = new System.Windows.Forms.Label();
            this.TxbForgotUser = new System.Windows.Forms.TextBox();
            this.LblForgotEmail = new System.Windows.Forms.Label();
            this.TxbForgotEmail = new System.Windows.Forms.TextBox();
            this.LblNewPassword = new System.Windows.Forms.Label();
            this.TxbNewPassword = new System.Windows.Forms.TextBox();
            this.PickBack2 = new System.Windows.Forms.PictureBox();
            this.BtnChangePassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PickBack2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblForgotUser
            // 
            this.LblForgotUser.AutoSize = true;
            this.LblForgotUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(169)))));
            this.LblForgotUser.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblForgotUser.ForeColor = System.Drawing.Color.Black;
            this.LblForgotUser.Location = new System.Drawing.Point(988, 434);
            this.LblForgotUser.Name = "LblForgotUser";
            this.LblForgotUser.Size = new System.Drawing.Size(149, 35);
            this.LblForgotUser.TabIndex = 2;
            this.LblForgotUser.Text = "Usuário:";
            // 
            // TxbForgotUser
            // 
            this.TxbForgotUser.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.TxbForgotUser.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbForgotUser.Location = new System.Drawing.Point(994, 472);
            this.TxbForgotUser.Multiline = true;
            this.TxbForgotUser.Name = "TxbForgotUser";
            this.TxbForgotUser.Size = new System.Drawing.Size(556, 44);
            this.TxbForgotUser.TabIndex = 5;
            this.TxbForgotUser.TextChanged += new System.EventHandler(this.TxbCreateUser_TextChanged);
            // 
            // LblForgotEmail
            // 
            this.LblForgotEmail.AutoSize = true;
            this.LblForgotEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(169)))));
            this.LblForgotEmail.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblForgotEmail.ForeColor = System.Drawing.Color.Black;
            this.LblForgotEmail.Location = new System.Drawing.Point(988, 547);
            this.LblForgotEmail.Name = "LblForgotEmail";
            this.LblForgotEmail.Size = new System.Drawing.Size(125, 35);
            this.LblForgotEmail.TabIndex = 6;
            this.LblForgotEmail.Text = "E-mail:";
            // 
            // TxbForgotEmail
            // 
            this.TxbForgotEmail.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.TxbForgotEmail.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbForgotEmail.Location = new System.Drawing.Point(994, 585);
            this.TxbForgotEmail.Multiline = true;
            this.TxbForgotEmail.Name = "TxbForgotEmail";
            this.TxbForgotEmail.Size = new System.Drawing.Size(556, 44);
            this.TxbForgotEmail.TabIndex = 7;
            // 
            // LblNewPassword
            // 
            this.LblNewPassword.AutoSize = true;
            this.LblNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(169)))));
            this.LblNewPassword.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewPassword.ForeColor = System.Drawing.Color.Black;
            this.LblNewPassword.Location = new System.Drawing.Point(988, 673);
            this.LblNewPassword.Name = "LblNewPassword";
            this.LblNewPassword.Size = new System.Drawing.Size(212, 35);
            this.LblNewPassword.TabIndex = 8;
            this.LblNewPassword.Text = "Nova senha:";
            // 
            // TxbNewPassword
            // 
            this.TxbNewPassword.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.TxbNewPassword.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbNewPassword.Location = new System.Drawing.Point(994, 711);
            this.TxbNewPassword.Multiline = true;
            this.TxbNewPassword.Name = "TxbNewPassword";
            this.TxbNewPassword.PasswordChar = '•';
            this.TxbNewPassword.Size = new System.Drawing.Size(556, 44);
            this.TxbNewPassword.TabIndex = 9;
            // 
            // PickBack2
            // 
            this.PickBack2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PickBack2.Image = ((System.Drawing.Image)(resources.GetObject("PickBack2.Image")));
            this.PickBack2.InitialImage = ((System.Drawing.Image)(resources.GetObject("PickBack2.InitialImage")));
            this.PickBack2.Location = new System.Drawing.Point(174, 121);
            this.PickBack2.Name = "PickBack2";
            this.PickBack2.Size = new System.Drawing.Size(93, 92);
            this.PickBack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PickBack2.TabIndex = 10;
            this.PickBack2.TabStop = false;
            this.PickBack2.Click += new System.EventHandler(this.PickBack2_Click);
            // 
            // BtnChangePassword
            // 
            this.BtnChangePassword.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChangePassword.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangePassword.Location = new System.Drawing.Point(1212, 797);
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.Size = new System.Drawing.Size(191, 54);
            this.BtnChangePassword.TabIndex = 11;
            this.BtnChangePassword.Text = "SALVAR";
            this.BtnChangePassword.UseVisualStyleBackColor = false;
            this.BtnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.BtnChangePassword);
            this.Controls.Add(this.PickBack2);
            this.Controls.Add(this.TxbNewPassword);
            this.Controls.Add(this.LblNewPassword);
            this.Controls.Add(this.TxbForgotEmail);
            this.Controls.Add(this.LblForgotEmail);
            this.Controls.Add(this.TxbForgotUser);
            this.Controls.Add(this.LblForgotUser);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PickBack2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblForgotUser;
        private System.Windows.Forms.TextBox TxbForgotUser;
        private System.Windows.Forms.Label LblForgotEmail;
        private System.Windows.Forms.TextBox TxbForgotEmail;
        private System.Windows.Forms.Label LblNewPassword;
        private System.Windows.Forms.TextBox TxbNewPassword;
        private System.Windows.Forms.PictureBox PickBack2;
        private System.Windows.Forms.Button BtnChangePassword;
    }
}