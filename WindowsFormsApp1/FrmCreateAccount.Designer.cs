namespace WindowsFormsApp1
{
    partial class FrmCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateAccount));
            this.LblCreateUser = new System.Windows.Forms.Label();
            this.LblCreateEmail = new System.Windows.Forms.Label();
            this.LblCreatePassword = new System.Windows.Forms.Label();
            this.TxbUser = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnCreateAccount = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PickBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PickBack)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCreateUser
            // 
            this.LblCreateUser.AutoSize = true;
            this.LblCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(169)))));
            this.LblCreateUser.Font = new System.Drawing.Font("Noto Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCreateUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.LblCreateUser.Location = new System.Drawing.Point(1025, 430);
            this.LblCreateUser.Name = "LblCreateUser";
            this.LblCreateUser.Size = new System.Drawing.Size(156, 49);
            this.LblCreateUser.TabIndex = 0;
            this.LblCreateUser.Text = "Usuário:";
            this.LblCreateUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblCreateEmail
            // 
            this.LblCreateEmail.AutoSize = true;
            this.LblCreateEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(169)))));
            this.LblCreateEmail.Font = new System.Drawing.Font("Noto Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCreateEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.LblCreateEmail.Location = new System.Drawing.Point(1025, 520);
            this.LblCreateEmail.Name = "LblCreateEmail";
            this.LblCreateEmail.Size = new System.Drawing.Size(129, 49);
            this.LblCreateEmail.TabIndex = 1;
            this.LblCreateEmail.Text = "E-mail:";
            this.LblCreateEmail.Click += new System.EventHandler(this.LblCreateEmail_Click);
            // 
            // LblCreatePassword
            // 
            this.LblCreatePassword.AutoSize = true;
            this.LblCreatePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(169)))));
            this.LblCreatePassword.Font = new System.Drawing.Font("Noto Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCreatePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.LblCreatePassword.Location = new System.Drawing.Point(1025, 621);
            this.LblCreatePassword.Name = "LblCreatePassword";
            this.LblCreatePassword.Size = new System.Drawing.Size(129, 49);
            this.LblCreatePassword.TabIndex = 2;
            this.LblCreatePassword.Text = "Senha:";
            // 
            // TxbUser
            // 
            this.TxbUser.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.TxbUser.Font = new System.Drawing.Font("Noto Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbUser.Location = new System.Drawing.Point(1034, 473);
            this.TxbUser.Multiline = true;
            this.TxbUser.Name = "TxbUser";
            this.TxbUser.Size = new System.Drawing.Size(386, 44);
            this.TxbUser.TabIndex = 4;
            this.TxbUser.TextChanged += new System.EventHandler(this.TxbUser_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textBox1.Font = new System.Drawing.Font("Noto Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1034, 663);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(386, 44);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textBox2.Font = new System.Drawing.Font("Noto Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1034, 562);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(386, 44);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BtnCreateAccount
            // 
            this.BtnCreateAccount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreateAccount.Font = new System.Drawing.Font("Noto Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateAccount.Location = new System.Drawing.Point(1279, 764);
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Size = new System.Drawing.Size(141, 54);
            this.BtnCreateAccount.TabIndex = 7;
            this.BtnCreateAccount.Text = "Criar";
            this.BtnCreateAccount.UseVisualStyleBackColor = false;
            this.BtnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // PickBack
            // 
            this.PickBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PickBack.Image = ((System.Drawing.Image)(resources.GetObject("PickBack.Image")));
            this.PickBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("PickBack.InitialImage")));
            this.PickBack.Location = new System.Drawing.Point(3, 0);
            this.PickBack.Name = "PickBack";
            this.PickBack.Size = new System.Drawing.Size(129, 114);
            this.PickBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PickBack.TabIndex = 8;
            this.PickBack.TabStop = false;
            this.PickBack.Click += new System.EventHandler(this.PickBack_Click);
            // 
            // FrmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.PickBack);
            this.Controls.Add(this.BtnCreateAccount);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TxbUser);
            this.Controls.Add(this.LblCreatePassword);
            this.Controls.Add(this.LblCreateEmail);
            this.Controls.Add(this.LblCreateUser);
            this.Name = "FrmCreateAccount";
            this.Text = "Criar Conta";
            ((System.ComponentModel.ISupportInitialize)(this.PickBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCreateUser;
        private System.Windows.Forms.Label LblCreateEmail;
        private System.Windows.Forms.Label LblCreatePassword;
        private System.Windows.Forms.TextBox TxbUser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnCreateAccount;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox PickBack;
    }
}