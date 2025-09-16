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
            this.LblChangePassword = new System.Windows.Forms.Label();
            this.TxbChangePassword = new System.Windows.Forms.TextBox();
            this.LblChangePassword2 = new System.Windows.Forms.Label();
            this.TxbChangePassword2 = new System.Windows.Forms.TextBox();
            this.BtnChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblChangePassword
            // 
            this.LblChangePassword.AutoSize = true;
            this.LblChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            this.LblChangePassword.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.LblChangePassword.Location = new System.Drawing.Point(786, 412);
            this.LblChangePassword.Name = "LblChangePassword";
            this.LblChangePassword.Size = new System.Drawing.Size(340, 35);
            this.LblChangePassword.TabIndex = 7;
            this.LblChangePassword.Text = "Insira a nova senha:";
            this.LblChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblChangePassword.Click += new System.EventHandler(this.LblChangePassword_Click);
            // 
            // TxbChangePassword
            // 
            this.TxbChangePassword.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.TxbChangePassword.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbChangePassword.Location = new System.Drawing.Point(675, 450);
            this.TxbChangePassword.Multiline = true;
            this.TxbChangePassword.Name = "TxbChangePassword";
            this.TxbChangePassword.Size = new System.Drawing.Size(556, 55);
            this.TxbChangePassword.TabIndex = 8;
            this.TxbChangePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblChangePassword2
            // 
            this.LblChangePassword2.AutoSize = true;
            this.LblChangePassword2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            this.LblChangePassword2.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChangePassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.LblChangePassword2.Location = new System.Drawing.Point(748, 540);
            this.LblChangePassword2.Name = "LblChangePassword2";
            this.LblChangePassword2.Size = new System.Drawing.Size(393, 35);
            this.LblChangePassword2.TabIndex = 9;
            this.LblChangePassword2.Text = "Confirme a nova senha:";
            this.LblChangePassword2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxbChangePassword2
            // 
            this.TxbChangePassword2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.TxbChangePassword2.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbChangePassword2.Location = new System.Drawing.Point(675, 578);
            this.TxbChangePassword2.Multiline = true;
            this.TxbChangePassword2.Name = "TxbChangePassword2";
            this.TxbChangePassword2.Size = new System.Drawing.Size(556, 55);
            this.TxbChangePassword2.TabIndex = 10;
            this.TxbChangePassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnChangePassword
            // 
            this.BtnChangePassword.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChangePassword.Font = new System.Drawing.Font("Swis721 BlkCn BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangePassword.Location = new System.Drawing.Point(797, 671);
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.Size = new System.Drawing.Size(288, 52);
            this.BtnChangePassword.TabIndex = 12;
            this.BtnChangePassword.Text = "SALVAR ALTERAÇÕES";
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
            this.Controls.Add(this.LblChangePassword2);
            this.Controls.Add(this.TxbChangePassword);
            this.Controls.Add(this.LblChangePassword);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblChangePassword;
        private System.Windows.Forms.TextBox TxbChangePassword;
        private System.Windows.Forms.Label LblChangePassword2;
        private System.Windows.Forms.TextBox TxbChangePassword2;
        private System.Windows.Forms.Button BtnChangePassword;
    }
}