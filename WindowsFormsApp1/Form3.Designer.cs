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
            this.LblForgotPassword = new System.Windows.Forms.Label();
            this.TxbForgotEmail = new System.Windows.Forms.TextBox();
            this.PickBack2 = new System.Windows.Forms.PictureBox();
            this.BtnSendCode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbEnterCode = new System.Windows.Forms.TextBox();
            this.BtnConfirmCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PickBack2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblForgotPassword
            // 
            this.LblForgotPassword.AutoSize = true;
            this.LblForgotPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            this.LblForgotPassword.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.LblForgotPassword.Location = new System.Drawing.Point(766, 386);
            this.LblForgotPassword.Name = "LblForgotPassword";
            this.LblForgotPassword.Size = new System.Drawing.Size(498, 70);
            this.LblForgotPassword.TabIndex = 6;
            this.LblForgotPassword.Text = "Insira seu e-mail para receber\r\num código de verificação:";
            this.LblForgotPassword.Click += new System.EventHandler(this.LblForgotEmail_Click);
            // 
            // TxbForgotEmail
            // 
            this.TxbForgotEmail.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.TxbForgotEmail.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbForgotEmail.Location = new System.Drawing.Point(772, 459);
            this.TxbForgotEmail.Multiline = true;
            this.TxbForgotEmail.Name = "TxbForgotEmail";
            this.TxbForgotEmail.Size = new System.Drawing.Size(556, 55);
            this.TxbForgotEmail.TabIndex = 7;
            // 
            // PickBack2
            // 
            this.PickBack2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PickBack2.Image = ((System.Drawing.Image)(resources.GetObject("PickBack2.Image")));
            this.PickBack2.InitialImage = ((System.Drawing.Image)(resources.GetObject("PickBack2.InitialImage")));
            this.PickBack2.Location = new System.Drawing.Point(12, 12);
            this.PickBack2.Name = "PickBack2";
            this.PickBack2.Size = new System.Drawing.Size(139, 133);
            this.PickBack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PickBack2.TabIndex = 10;
            this.PickBack2.TabStop = false;
            this.PickBack2.Click += new System.EventHandler(this.PickBack2_Click);
            // 
            // BtnSendCode
            // 
            this.BtnSendCode.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSendCode.Font = new System.Drawing.Font("Swis721 BlkCn BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSendCode.Location = new System.Drawing.Point(918, 523);
            this.BtnSendCode.Name = "BtnSendCode";
            this.BtnSendCode.Size = new System.Drawing.Size(288, 52);
            this.BtnSendCode.TabIndex = 11;
            this.BtnSendCode.Text = "ENVIAR CÓDIGO";
            this.BtnSendCode.UseVisualStyleBackColor = false;
            this.BtnSendCode.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(766, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "Insira aqui seu código:\r\n";
            // 
            // TxbEnterCode
            // 
            this.TxbEnterCode.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.TxbEnterCode.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbEnterCode.Location = new System.Drawing.Point(772, 641);
            this.TxbEnterCode.Multiline = true;
            this.TxbEnterCode.Name = "TxbEnterCode";
            this.TxbEnterCode.Size = new System.Drawing.Size(556, 55);
            this.TxbEnterCode.TabIndex = 13;
            // 
            // BtnConfirmCode
            // 
            this.BtnConfirmCode.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnConfirmCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirmCode.Font = new System.Drawing.Font("Swis721 BlkCn BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmCode.Location = new System.Drawing.Point(918, 702);
            this.BtnConfirmCode.Name = "BtnConfirmCode";
            this.BtnConfirmCode.Size = new System.Drawing.Size(288, 52);
            this.BtnConfirmCode.TabIndex = 14;
            this.BtnConfirmCode.Text = "VERIFICAR";
            this.BtnConfirmCode.UseVisualStyleBackColor = false;
            this.BtnConfirmCode.Click += new System.EventHandler(this.BtnConfirmCode_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.BtnConfirmCode);
            this.Controls.Add(this.TxbEnterCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSendCode);
            this.Controls.Add(this.PickBack2);
            this.Controls.Add(this.TxbForgotEmail);
            this.Controls.Add(this.LblForgotPassword);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PickBack2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblForgotPassword;
        private System.Windows.Forms.TextBox TxbForgotEmail;
        private System.Windows.Forms.PictureBox PickBack2;
        private System.Windows.Forms.Button BtnSendCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbEnterCode;
        private System.Windows.Forms.Button BtnConfirmCode;
    }
}