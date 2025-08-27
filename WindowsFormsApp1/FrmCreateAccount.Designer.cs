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
            this.TxbCreateUser = new System.Windows.Forms.TextBox();
            this.TxbCreatePassword = new System.Windows.Forms.TextBox();
            this.TxbEmail = new System.Windows.Forms.TextBox();
            this.BtnCreateAccount = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PickBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PickBack)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCreateUser
            // 
            this.LblCreateUser.AutoSize = true;
            this.LblCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.LblCreateUser.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCreateUser.ForeColor = System.Drawing.Color.Black;
            this.LblCreateUser.Location = new System.Drawing.Point(1028, 435);
            this.LblCreateUser.Name = "LblCreateUser";
            this.LblCreateUser.Size = new System.Drawing.Size(149, 35);
            this.LblCreateUser.TabIndex = 0;
            this.LblCreateUser.Text = "Usuário:";
            this.LblCreateUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblCreateEmail
            // 
            this.LblCreateEmail.AutoSize = true;
            this.LblCreateEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.LblCreateEmail.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCreateEmail.ForeColor = System.Drawing.Color.Black;
            this.LblCreateEmail.Location = new System.Drawing.Point(1028, 530);
            this.LblCreateEmail.Name = "LblCreateEmail";
            this.LblCreateEmail.Size = new System.Drawing.Size(125, 35);
            this.LblCreateEmail.TabIndex = 1;
            this.LblCreateEmail.Text = "E-mail:";
            this.LblCreateEmail.Click += new System.EventHandler(this.LblCreateEmail_Click);
            // 
            // LblCreatePassword
            // 
            this.LblCreatePassword.AutoSize = true;
            this.LblCreatePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.LblCreatePassword.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCreatePassword.ForeColor = System.Drawing.Color.Black;
            this.LblCreatePassword.Location = new System.Drawing.Point(1028, 625);
            this.LblCreatePassword.Name = "LblCreatePassword";
            this.LblCreatePassword.Size = new System.Drawing.Size(125, 35);
            this.LblCreatePassword.TabIndex = 2;
            this.LblCreatePassword.Text = "Senha:";
            // 
            // TxbCreateUser
            // 
            this.TxbCreateUser.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.TxbCreateUser.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbCreateUser.Location = new System.Drawing.Point(1034, 473);
            this.TxbCreateUser.Multiline = true;
            this.TxbCreateUser.Name = "TxbCreateUser";
            this.TxbCreateUser.Size = new System.Drawing.Size(556, 44);
            this.TxbCreateUser.TabIndex = 4;
            this.TxbCreateUser.TextChanged += new System.EventHandler(this.TxbUser_TextChanged);
            // 
            // TxbCreatePassword
            // 
            this.TxbCreatePassword.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.TxbCreatePassword.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbCreatePassword.Location = new System.Drawing.Point(1034, 663);
            this.TxbCreatePassword.Multiline = true;
            this.TxbCreatePassword.Name = "TxbCreatePassword";
            this.TxbCreatePassword.PasswordChar = '•';
            this.TxbCreatePassword.Size = new System.Drawing.Size(556, 44);
            this.TxbCreatePassword.TabIndex = 5;
            // 
            // TxbEmail
            // 
            this.TxbEmail.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.TxbEmail.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbEmail.Location = new System.Drawing.Point(1034, 569);
            this.TxbEmail.Multiline = true;
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Size = new System.Drawing.Size(556, 44);
            this.TxbEmail.TabIndex = 6;
            this.TxbEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BtnCreateAccount
            // 
            this.BtnCreateAccount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreateAccount.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateAccount.Location = new System.Drawing.Point(1274, 743);
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Size = new System.Drawing.Size(191, 54);
            this.BtnCreateAccount.TabIndex = 7;
            this.BtnCreateAccount.Text = "CRIAR";
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
            this.PickBack.Size = new System.Drawing.Size(93, 92);
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
            this.Controls.Add(this.TxbEmail);
            this.Controls.Add(this.TxbCreatePassword);
            this.Controls.Add(this.TxbCreateUser);
            this.Controls.Add(this.LblCreatePassword);
            this.Controls.Add(this.LblCreateEmail);
            this.Controls.Add(this.LblCreateUser);
            this.Name = "FrmCreateAccount";
            this.Text = "Criar Conta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCreateAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PickBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCreateUser;
        private System.Windows.Forms.Label LblCreateEmail;
        private System.Windows.Forms.Label LblCreatePassword;
        private System.Windows.Forms.TextBox TxbCreateUser;
        private System.Windows.Forms.TextBox TxbCreatePassword;
        private System.Windows.Forms.TextBox TxbEmail;
        private System.Windows.Forms.Button BtnCreateAccount;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox PickBack;
    }
}