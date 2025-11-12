namespace WindowsFormsApp1
{
    partial class SegundaProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SegundaProf));
            this.Panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblVerAulas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AgendarAulas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblAlunos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lblteacher = new System.Windows.Forms.Label();
            this.LblArrow3 = new System.Windows.Forms.Label();
            this.LblCursos = new System.Windows.Forms.Label();
            this.LblPic3 = new System.Windows.Forms.Label();
            this.LblArrow2 = new System.Windows.Forms.Label();
            this.LblEmailUser2 = new System.Windows.Forms.Label();
            this.LblNameUser2 = new System.Windows.Forms.Label();
            this.LblPic2 = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.timerVerificarAulas = new System.Windows.Forms.Timer(this.components);
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(125)))));
            this.Panel3.Controls.Add(this.label5);
            this.Panel3.Controls.Add(this.label4);
            this.Panel3.Controls.Add(this.LblVerAulas);
            this.Panel3.Controls.Add(this.label3);
            this.Panel3.Controls.Add(this.AgendarAulas);
            this.Panel3.Controls.Add(this.label2);
            this.Panel3.Controls.Add(this.LblAlunos);
            this.Panel3.Controls.Add(this.label1);
            this.Panel3.Controls.Add(this.Lblteacher);
            this.Panel3.Controls.Add(this.LblArrow3);
            this.Panel3.Controls.Add(this.LblCursos);
            this.Panel3.Controls.Add(this.LblPic3);
            this.Panel3.Controls.Add(this.LblArrow2);
            this.Panel3.Controls.Add(this.LblEmailUser2);
            this.Panel3.Controls.Add(this.LblNameUser2);
            this.Panel3.Controls.Add(this.LblPic2);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel3.ForeColor = System.Drawing.Color.Transparent;
            this.Panel3.Location = new System.Drawing.Point(0, 0);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(494, 1061);
            this.Panel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.label5.Location = new System.Drawing.Point(90, 944);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = "Excluir conta";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.label4.Location = new System.Drawing.Point(9, 928);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 61);
            this.label4.TabIndex = 14;
            this.label4.Text = "🗑";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // LblVerAulas
            // 
            this.LblVerAulas.AutoSize = true;
            this.LblVerAulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.LblVerAulas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LblVerAulas.Location = new System.Drawing.Point(91, 456);
            this.LblVerAulas.Name = "LblVerAulas";
            this.LblVerAulas.Size = new System.Drawing.Size(239, 33);
            this.LblVerAulas.TabIndex = 13;
            this.LblVerAulas.Text = "Aulas agendadas";
            this.LblVerAulas.Click += new System.EventHandler(this.LblVerAulas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.label3.Location = new System.Drawing.Point(9, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 61);
            this.label3.TabIndex = 12;
            this.label3.Text = "📅";
            // 
            // AgendarAulas
            // 
            this.AgendarAulas.AutoSize = true;
            this.AgendarAulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.AgendarAulas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.AgendarAulas.Location = new System.Drawing.Point(90, 380);
            this.AgendarAulas.Name = "AgendarAulas";
            this.AgendarAulas.Size = new System.Drawing.Size(202, 33);
            this.AgendarAulas.TabIndex = 11;
            this.AgendarAulas.Text = "Agendar aulas";
            this.AgendarAulas.Click += new System.EventHandler(this.AgendarAulas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.label2.Location = new System.Drawing.Point(9, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 61);
            this.label2.TabIndex = 10;
            this.label2.Text = "➕";
            // 
            // LblAlunos
            // 
            this.LblAlunos.AutoSize = true;
            this.LblAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.LblAlunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LblAlunos.Location = new System.Drawing.Point(90, 310);
            this.LblAlunos.Name = "LblAlunos";
            this.LblAlunos.Size = new System.Drawing.Size(104, 33);
            this.LblAlunos.TabIndex = 9;
            this.LblAlunos.Text = "Alunos";
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
            this.label1.TabIndex = 8;
            this.label1.Text = "🎓";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lblteacher
            // 
            this.Lblteacher.AutoSize = true;
            this.Lblteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblteacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.Lblteacher.Location = new System.Drawing.Point(15, 60);
            this.Lblteacher.Name = "Lblteacher";
            this.Lblteacher.Size = new System.Drawing.Size(334, 55);
            this.Lblteacher.TabIndex = 7;
            this.Lblteacher.Text = "PROFESSOR";
            this.Lblteacher.Click += new System.EventHandler(this.Lblteacher_Click);
            // 
            // LblArrow3
            // 
            this.LblArrow3.AutoSize = true;
            this.LblArrow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArrow3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LblArrow3.Location = new System.Drawing.Point(222, 249);
            this.LblArrow3.Name = "LblArrow3";
            this.LblArrow3.Size = new System.Drawing.Size(33, 31);
            this.LblArrow3.TabIndex = 6;
            this.LblArrow3.Text = "▼";
            this.LblArrow3.Click += new System.EventHandler(this.LblArrow3_Click);
            // 
            // LblCursos
            // 
            this.LblCursos.AutoSize = true;
            this.LblCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.LblCursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LblCursos.Location = new System.Drawing.Point(90, 246);
            this.LblCursos.Name = "LblCursos";
            this.LblCursos.Size = new System.Drawing.Size(108, 33);
            this.LblCursos.TabIndex = 5;
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
            this.LblPic3.TabIndex = 4;
            this.LblPic3.Text = "📚";
            // 
            // LblArrow2
            // 
            this.LblArrow2.AutoSize = true;
            this.LblArrow2.BackColor = System.Drawing.Color.Transparent;
            this.LblArrow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArrow2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LblArrow2.Location = new System.Drawing.Point(458, 158);
            this.LblArrow2.Name = "LblArrow2";
            this.LblArrow2.Size = new System.Drawing.Size(33, 31);
            this.LblArrow2.TabIndex = 3;
            this.LblArrow2.Text = "▼";
            this.LblArrow2.Click += new System.EventHandler(this.LblArrow2_Click);
            // 
            // LblEmailUser2
            // 
            this.LblEmailUser2.AutoSize = true;
            this.LblEmailUser2.BackColor = System.Drawing.Color.Transparent;
            this.LblEmailUser2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.LblEmailUser2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LblEmailUser2.Location = new System.Drawing.Point(90, 173);
            this.LblEmailUser2.Name = "LblEmailUser2";
            this.LblEmailUser2.Size = new System.Drawing.Size(93, 33);
            this.LblEmailUser2.TabIndex = 2;
            this.LblEmailUser2.Text = "label1";
            // 
            // LblNameUser2
            // 
            this.LblNameUser2.AutoSize = true;
            this.LblNameUser2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameUser2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LblNameUser2.Location = new System.Drawing.Point(90, 138);
            this.LblNameUser2.Name = "LblNameUser2";
            this.LblNameUser2.Size = new System.Drawing.Size(93, 33);
            this.LblNameUser2.TabIndex = 1;
            this.LblNameUser2.Text = "label1";
            this.LblNameUser2.Click += new System.EventHandler(this.LblNameUser_Click);
            // 
            // LblPic2
            // 
            this.LblPic2.AutoSize = true;
            this.LblPic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPic2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.LblPic2.Location = new System.Drawing.Point(3, 132);
            this.LblPic2.Name = "LblPic2";
            this.LblPic2.Size = new System.Drawing.Size(109, 76);
            this.LblPic2.TabIndex = 0;
            this.LblPic2.Text = "👤";
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel4.Location = new System.Drawing.Point(494, 0);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(1430, 1061);
            this.Panel4.TabIndex = 2;
            // 
            // timerVerificarAulas
            // 
            this.timerVerificarAulas.Enabled = true;
            this.timerVerificarAulas.Interval = 60000;
            this.timerVerificarAulas.Tick += new System.EventHandler(this.timerVerificarAulas_Tick);
            // 
            // SegundaProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel3);
            this.Name = "SegundaProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disciplinas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Disciplinas_Load);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.Label LblArrow2;
        private System.Windows.Forms.Label LblEmailUser2;
        private System.Windows.Forms.Label LblNameUser2;
        private System.Windows.Forms.Label LblPic2;
        private System.Windows.Forms.Panel Panel4;
        private System.Windows.Forms.Label LblCursos;
        private System.Windows.Forms.Label LblPic3;
        private System.Windows.Forms.Label LblArrow3;
        private System.Windows.Forms.Label Lblteacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblAlunos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AgendarAulas;
        private System.Windows.Forms.Label LblVerAulas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerVerificarAulas;
    }
}