namespace WindowsFormsApp1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.TxbChangePassword = new System.Windows.Forms.TextBox();
            this.TxbChangePassword2 = new System.Windows.Forms.TextBox();
            this.BtnChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxbChangePassword
            // 
            this.TxbChangePassword.BackColor = System.Drawing.Color.White;
            this.TxbChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbChangePassword.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbChangePassword.Location = new System.Drawing.Point(665, 492);
            this.TxbChangePassword.Multiline = true;
            this.TxbChangePassword.Name = "TxbChangePassword";
            this.TxbChangePassword.PasswordChar = '•';
            this.TxbChangePassword.Size = new System.Drawing.Size(556, 55);
            this.TxbChangePassword.TabIndex = 8;
            this.TxbChangePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxbChangePassword.TextChanged += new System.EventHandler(this.TxbChangePassword_TextChanged);
            // 
            // TxbChangePassword2
            // 
            this.TxbChangePassword2.BackColor = System.Drawing.Color.White;
            this.TxbChangePassword2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbChangePassword2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbChangePassword2.Location = new System.Drawing.Point(665, 627);
            this.TxbChangePassword2.Multiline = true;
            this.TxbChangePassword2.Name = "TxbChangePassword2";
            this.TxbChangePassword2.PasswordChar = '•';
            this.TxbChangePassword2.Size = new System.Drawing.Size(556, 55);
            this.TxbChangePassword2.TabIndex = 10;
            this.TxbChangePassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnChangePassword
            // 
            this.BtnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(115)))), ((int)(((byte)(151)))));
            this.BtnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChangePassword.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.BtnChangePassword.Location = new System.Drawing.Point(881, 726);
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.Size = new System.Drawing.Size(206, 71);
            this.BtnChangePassword.TabIndex = 12;
            this.BtnChangePassword.Text = "Salvar";
            this.BtnChangePassword.UseVisualStyleBackColor = false;
            this.BtnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.BtnChangePassword);
            this.Controls.Add(this.TxbChangePassword2);
            this.Controls.Add(this.TxbChangePassword);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxbChangePassword;
        private System.Windows.Forms.TextBox TxbChangePassword2;
        private System.Windows.Forms.Button BtnChangePassword;
    }
}