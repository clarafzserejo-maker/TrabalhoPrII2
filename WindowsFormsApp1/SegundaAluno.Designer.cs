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
            this.LblAlunos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblArrow3 = new System.Windows.Forms.Label();
            this.LblCursos = new System.Windows.Forms.Label();
            this.LblPic3 = new System.Windows.Forms.Label();
            this.LblArrow = new System.Windows.Forms.Label();
            this.LblEmailUser = new System.Windows.Forms.Label();
            this.LblNameUser = new System.Windows.Forms.Label();
            this.LblPic = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Sair = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TelaMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Lblteacher = new System.Windows.Forms.Label();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(125)))));
            this.Panel1.Controls.Add(this.LblAlunos);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.LblArrow3);
            this.Panel1.Controls.Add(this.LblCursos);
            this.Panel1.Controls.Add(this.LblPic3);
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
            // LblAlunos
            // 
            this.LblAlunos.AutoSize = true;
            this.LblAlunos.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.LblAlunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LblAlunos.Location = new System.Drawing.Point(90, 312);
            this.LblAlunos.Name = "LblAlunos";
            this.LblAlunos.Size = new System.Drawing.Size(168, 36);
            this.LblAlunos.TabIndex = 11;
            this.LblAlunos.Text = "Professores";
            this.LblAlunos.Click += new System.EventHandler(this.LblAlunos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(3, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 73);
            this.label1.TabIndex = 10;
            this.label1.Text = "🎓";
            // 
            // LblArrow3
            // 
            this.LblArrow3.AutoSize = true;
            this.LblArrow3.BackColor = System.Drawing.Color.Transparent;
            this.LblArrow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArrow3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LblArrow3.Location = new System.Drawing.Point(222, 249);
            this.LblArrow3.Name = "LblArrow3";
            this.LblArrow3.Size = new System.Drawing.Size(33, 31);
            this.LblArrow3.TabIndex = 7;
            this.LblArrow3.Text = "▼";
            this.LblArrow3.Click += new System.EventHandler(this.LblArrow3_Click);
            // 
            // LblCursos
            // 
            this.LblCursos.AutoSize = true;
            this.LblCursos.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.LblCursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LblCursos.Location = new System.Drawing.Point(90, 246);
            this.LblCursos.Name = "LblCursos";
            this.LblCursos.Size = new System.Drawing.Size(107, 36);
            this.LblCursos.TabIndex = 6;
            this.LblCursos.Text = "Cursos";
            // 
            // LblPic3
            // 
            this.LblPic3.AutoSize = true;
            this.LblPic3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPic3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LblPic3.Location = new System.Drawing.Point(2, 212);
            this.LblPic3.Name = "LblPic3";
            this.LblPic3.Size = new System.Drawing.Size(103, 73);
            this.LblPic3.TabIndex = 5;
            this.LblPic3.Text = "📚";
            // 
            // LblArrow
            // 
            this.LblArrow.AutoSize = true;
            this.LblArrow.BackColor = System.Drawing.Color.Transparent;
            this.LblArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LblArrow.Location = new System.Drawing.Point(458, 158);
            this.LblArrow.Name = "LblArrow";
            this.LblArrow.Size = new System.Drawing.Size(33, 31);
            this.LblArrow.TabIndex = 3;
            this.LblArrow.Text = "▼";
            this.LblArrow.Click += new System.EventHandler(this.LblArrow_Click);
            // 
            // LblEmailUser
            // 
            this.LblEmailUser.AutoSize = true;
            this.LblEmailUser.BackColor = System.Drawing.Color.Transparent;
            this.LblEmailUser.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.LblEmailUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LblEmailUser.Location = new System.Drawing.Point(90, 173);
            this.LblEmailUser.Name = "LblEmailUser";
            this.LblEmailUser.Size = new System.Drawing.Size(102, 36);
            this.LblEmailUser.TabIndex = 2;
            this.LblEmailUser.Text = "label1";
            // 
            // LblNameUser
            // 
            this.LblNameUser.AutoSize = true;
            this.LblNameUser.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LblNameUser.Location = new System.Drawing.Point(90, 138);
            this.LblNameUser.Name = "LblNameUser";
            this.LblNameUser.Size = new System.Drawing.Size(102, 36);
            this.LblNameUser.TabIndex = 1;
            this.LblNameUser.Text = "label1";
            // 
            // LblPic
            // 
            this.LblPic.AutoSize = true;
            this.LblPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LblPic.Location = new System.Drawing.Point(3, 132);
            this.LblPic.Name = "LblPic";
            this.LblPic.Size = new System.Drawing.Size(109, 76);
            this.LblPic.TabIndex = 0;
            this.LblPic.Text = "👤";
            this.LblPic.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            // Lblteacher
            // 
            this.Lblteacher.AutoSize = true;
            this.Lblteacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(125)))));
            this.Lblteacher.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblteacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.Lblteacher.Location = new System.Drawing.Point(15, 60);
            this.Lblteacher.Name = "Lblteacher";
            this.Lblteacher.Size = new System.Drawing.Size(188, 56);
            this.Lblteacher.TabIndex = 8;
            this.Lblteacher.Text = "ALUNO";
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.Panel5.Location = new System.Drawing.Point(486, -1);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(1440, 1063);
            this.Panel5.TabIndex = 9;
            // 
            // SegundaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.Panel5);
            this.Controls.Add(this.Lblteacher);
            this.Controls.Add(this.Panel1);
            this.Name = "SegundaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SegundaAluno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SegundaAluno_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label Lblteacher;
        private System.Windows.Forms.Label LblPic3;
        private System.Windows.Forms.Label LblCursos;
        private System.Windows.Forms.Label LblArrow3;
        private System.Windows.Forms.Panel Panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblAlunos;
    }
}