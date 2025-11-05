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
            this.TxbCreateUser = new System.Windows.Forms.TextBox();
            this.TxbCreatePassword = new System.Windows.Forms.TextBox();
            this.TxbEmail = new System.Windows.Forms.TextBox();
            this.BtnCreateAccount = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.PickBack = new System.Windows.Forms.PictureBox();
            this.CheckBoxTeacher2 = new System.Windows.Forms.CheckBox();
            this.TxbCreateName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PickBack)).BeginInit();
            this.SuspendLayout();
            // 
            // TxbCreateUser
            // 
            this.TxbCreateUser.BackColor = System.Drawing.Color.White;
            this.TxbCreateUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbCreateUser.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.TxbCreateUser.Location = new System.Drawing.Point(653, 331);
            this.TxbCreateUser.Multiline = true;
            this.TxbCreateUser.Name = "TxbCreateUser";
            this.TxbCreateUser.Size = new System.Drawing.Size(618, 44);
            this.TxbCreateUser.TabIndex = 4;
            this.TxbCreateUser.TextChanged += new System.EventHandler(this.TxbUser_TextChanged);
            // 
            // TxbCreatePassword
            // 
            this.TxbCreatePassword.BackColor = System.Drawing.Color.White;
            this.TxbCreatePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbCreatePassword.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.TxbCreatePassword.Location = new System.Drawing.Point(653, 772);
            this.TxbCreatePassword.Multiline = true;
            this.TxbCreatePassword.Name = "TxbCreatePassword";
            this.TxbCreatePassword.PasswordChar = '•';
            this.TxbCreatePassword.Size = new System.Drawing.Size(618, 44);
            this.TxbCreatePassword.TabIndex = 5;
            // 
            // TxbEmail
            // 
            this.TxbEmail.BackColor = System.Drawing.Color.White;
            this.TxbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbEmail.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.TxbEmail.Location = new System.Drawing.Point(653, 624);
            this.TxbEmail.Multiline = true;
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Size = new System.Drawing.Size(618, 44);
            this.TxbEmail.TabIndex = 6;
            this.TxbEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BtnCreateAccount
            // 
            this.BtnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(115)))), ((int)(((byte)(151)))));
            this.BtnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreateAccount.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.BtnCreateAccount.Location = new System.Drawing.Point(818, 901);
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Size = new System.Drawing.Size(282, 73);
            this.BtnCreateAccount.TabIndex = 7;
            this.BtnCreateAccount.Text = "Criar conta";
            this.BtnCreateAccount.UseVisualStyleBackColor = false;
            this.BtnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // PickBack
            // 
            this.PickBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PickBack.Image = ((System.Drawing.Image)(resources.GetObject("PickBack.Image")));
            this.PickBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("PickBack.InitialImage")));
            this.PickBack.Location = new System.Drawing.Point(614, 71);
            this.PickBack.Name = "PickBack";
            this.PickBack.Size = new System.Drawing.Size(142, 88);
            this.PickBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PickBack.TabIndex = 8;
            this.PickBack.TabStop = false;
            this.PickBack.Click += new System.EventHandler(this.PickBack_Click);
            // 
            // CheckBoxTeacher2
            // 
            this.CheckBoxTeacher2.AutoSize = true;
            this.CheckBoxTeacher2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.CheckBoxTeacher2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxTeacher2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxTeacher2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(115)))), ((int)(((byte)(151)))));
            this.CheckBoxTeacher2.Location = new System.Drawing.Point(653, 836);
            this.CheckBoxTeacher2.Name = "CheckBoxTeacher2";
            this.CheckBoxTeacher2.Size = new System.Drawing.Size(363, 37);
            this.CheckBoxTeacher2.TabIndex = 13;
            this.CheckBoxTeacher2.Text = "Criar conta de educador";
            this.CheckBoxTeacher2.UseVisualStyleBackColor = false;
            // 
            // TxbCreateName
            // 
            this.TxbCreateName.BackColor = System.Drawing.Color.White;
            this.TxbCreateName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbCreateName.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.TxbCreateName.Location = new System.Drawing.Point(653, 479);
            this.TxbCreateName.Multiline = true;
            this.TxbCreateName.Name = "TxbCreateName";
            this.TxbCreateName.Size = new System.Drawing.Size(618, 44);
            this.TxbCreateName.TabIndex = 15;
            // 
            // FrmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.TxbCreateName);
            this.Controls.Add(this.CheckBoxTeacher2);
            this.Controls.Add(this.PickBack);
            this.Controls.Add(this.BtnCreateAccount);
            this.Controls.Add(this.TxbEmail);
            this.Controls.Add(this.TxbCreatePassword);
            this.Controls.Add(this.TxbCreateUser);
            this.Name = "FrmCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Conta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCreateAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PickBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxbCreateUser;
        private System.Windows.Forms.TextBox TxbCreatePassword;
        private System.Windows.Forms.TextBox TxbEmail;
        private System.Windows.Forms.Button BtnCreateAccount;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox PickBack;
        private System.Windows.Forms.CheckBox CheckBoxTeacher2;
        private System.Windows.Forms.TextBox TxbCreateName;
    }
}