namespace WindowsFormsApp1
{
    partial class SegundaAluno
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SegundaAluno));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LblPic = new System.Windows.Forms.Label();
            this.LblNameUser = new System.Windows.Forms.Label();
            this.LblEmailUser = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LblArrow = new System.Windows.Forms.Label();
            this.Sair = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TelaMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            this.Panel1.Controls.Add(this.LblArrow);
            this.Panel1.Controls.Add(this.LblEmailUser);
            this.Panel1.Controls.Add(this.LblNameUser);
            this.Panel1.Controls.Add(this.LblPic);
            this.Panel1.ForeColor = System.Drawing.Color.Transparent;
            this.Panel1.Location = new System.Drawing.Point(-2, -1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(494, 1063);
            this.Panel1.TabIndex = 0;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // LblPic
            // 
            this.LblPic.AutoSize = true;
            this.LblPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPic.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LblPic.Location = new System.Drawing.Point(3, 132);
            this.LblPic.Name = "LblPic";
            this.LblPic.Size = new System.Drawing.Size(109, 76);
            this.LblPic.TabIndex = 0;
            this.LblPic.Text = "👤";
            this.LblPic.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblNameUser
            // 
            this.LblNameUser.AutoSize = true;
            this.LblNameUser.Font = new System.Drawing.Font("Swis721 Blk BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LblNameUser.Location = new System.Drawing.Point(90, 138);
            this.LblNameUser.Name = "LblNameUser";
            this.LblNameUser.Size = new System.Drawing.Size(113, 35);
            this.LblNameUser.TabIndex = 1;
            this.LblNameUser.Text = "label1";
            // 
            // LblEmailUser
            // 
            this.LblEmailUser.AutoSize = true;
            this.LblEmailUser.BackColor = System.Drawing.Color.Transparent;
            this.LblEmailUser.Font = new System.Drawing.Font("Swis721 BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LblEmailUser.Location = new System.Drawing.Point(90, 173);
            this.LblEmailUser.Name = "LblEmailUser";
            this.LblEmailUser.Size = new System.Drawing.Size(94, 35);
            this.LblEmailUser.TabIndex = 2;
            this.LblEmailUser.Text = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LblArrow
            // 
            this.LblArrow.AutoSize = true;
            this.LblArrow.BackColor = System.Drawing.Color.Transparent;
            this.LblArrow.Font = new System.Drawing.Font("Swis721 Blk BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArrow.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LblArrow.Location = new System.Drawing.Point(458, 158);
            this.LblArrow.Name = "LblArrow";
            this.LblArrow.Size = new System.Drawing.Size(33, 32);
            this.LblArrow.TabIndex = 3;
            this.LblArrow.Text = "▼";
            this.LblArrow.Click += new System.EventHandler(this.LblArrow_Click);
            // 
            // Sair
            // 
            this.Sair.Name = "contextMenuStrip2";
            this.Sair.Size = new System.Drawing.Size(61, 4);
            // 
            // TelaMenu
            // 
            this.TelaMenu.Name = "TelaMenu";
            this.TelaMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // SegundaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.Panel1);
            this.Name = "SegundaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SegundaAluno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SegundaAluno_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label LblPic;
        private System.Windows.Forms.Label LblNameUser;
        private System.Windows.Forms.Label LblEmailUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label LblArrow;
        private System.Windows.Forms.ContextMenuStrip Sair;
        private System.Windows.Forms.ContextMenuStrip TelaMenu;
    }
}