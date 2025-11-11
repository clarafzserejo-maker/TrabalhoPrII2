namespace WindowsFormsApp1
{
    partial class AdicionarCursoControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarCursoControl));
            this.LblNomedoCurso = new System.Windows.Forms.Label();
            this.LblCargaHoraria = new System.Windows.Forms.Label();
            this.TxbNomeCurso = new System.Windows.Forms.TextBox();
            this.TxbCargaHoraria = new System.Windows.Forms.TextBox();
            this.BtnAddCourse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblTable = new System.Windows.Forms.Label();
            this.BtnSaveCourse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxbPesquisa3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNomedoCurso
            // 
            this.LblNomedoCurso.AutoSize = true;
            this.LblNomedoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomedoCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(115)))), ((int)(((byte)(151)))));
            this.LblNomedoCurso.Location = new System.Drawing.Point(64, 365);
            this.LblNomedoCurso.Name = "LblNomedoCurso";
            this.LblNomedoCurso.Size = new System.Drawing.Size(440, 32);
            this.LblNomedoCurso.TabIndex = 0;
            this.LblNomedoCurso.Text = "Digite o nome do curso/disciplina:";
            // 
            // LblCargaHoraria
            // 
            this.LblCargaHoraria.AutoSize = true;
            this.LblCargaHoraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargaHoraria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(115)))), ((int)(((byte)(151)))));
            this.LblCargaHoraria.Location = new System.Drawing.Point(64, 491);
            this.LblCargaHoraria.Name = "LblCargaHoraria";
            this.LblCargaHoraria.Size = new System.Drawing.Size(406, 32);
            this.LblCargaHoraria.TabIndex = 1;
            this.LblCargaHoraria.Text = "Carga horária do curso (horas):";
            this.LblCargaHoraria.Click += new System.EventHandler(this.LblCargaHoraria_Click);
            // 
            // TxbNomeCurso
            // 
            this.TxbNomeCurso.BackColor = System.Drawing.Color.White;
            this.TxbNomeCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbNomeCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbNomeCurso.ForeColor = System.Drawing.Color.Black;
            this.TxbNomeCurso.Location = new System.Drawing.Point(66, 413);
            this.TxbNomeCurso.Multiline = true;
            this.TxbNomeCurso.Name = "TxbNomeCurso";
            this.TxbNomeCurso.Size = new System.Drawing.Size(586, 45);
            this.TxbNomeCurso.TabIndex = 2;
            // 
            // TxbCargaHoraria
            // 
            this.TxbCargaHoraria.BackColor = System.Drawing.Color.White;
            this.TxbCargaHoraria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbCargaHoraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbCargaHoraria.ForeColor = System.Drawing.Color.Black;
            this.TxbCargaHoraria.Location = new System.Drawing.Point(66, 548);
            this.TxbCargaHoraria.Multiline = true;
            this.TxbCargaHoraria.Name = "TxbCargaHoraria";
            this.TxbCargaHoraria.Size = new System.Drawing.Size(579, 43);
            this.TxbCargaHoraria.TabIndex = 3;
            // 
            // BtnAddCourse
            // 
            this.BtnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(115)))), ((int)(((byte)(151)))));
            this.BtnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.BtnAddCourse.Location = new System.Drawing.Point(173, 685);
            this.BtnAddCourse.Name = "BtnAddCourse";
            this.BtnAddCourse.Size = new System.Drawing.Size(363, 50);
            this.BtnAddCourse.TabIndex = 4;
            this.BtnAddCourse.Text = "+ Adicionar curso";
            this.BtnAddCourse.UseVisualStyleBackColor = false;
            this.BtnAddCourse.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(213)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(143)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.dataGridView1.Location = new System.Drawing.Point(849, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(490, 312);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LblTable
            // 
            this.LblTable.AutoSize = true;
            this.LblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(115)))), ((int)(((byte)(151)))));
            this.LblTable.Location = new System.Drawing.Point(855, 112);
            this.LblTable.Name = "LblTable";
            this.LblTable.Size = new System.Drawing.Size(406, 64);
            this.LblTable.TabIndex = 6;
            this.LblTable.Text = "Verifique se esse curso já foi\r\ncadastrado (se sim, selecione):";
            // 
            // BtnSaveCourse
            // 
            this.BtnSaveCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(115)))), ((int)(((byte)(151)))));
            this.BtnSaveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.BtnSaveCourse.Location = new System.Drawing.Point(1010, 685);
            this.BtnSaveCourse.Name = "BtnSaveCourse";
            this.BtnSaveCourse.Size = new System.Drawing.Size(198, 50);
            this.BtnSaveCourse.TabIndex = 7;
            this.BtnSaveCourse.Text = "Salvar";
            this.BtnSaveCourse.UseVisualStyleBackColor = false;
            this.BtnSaveCourse.Click += new System.EventHandler(this.BtnSaveCourse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, -29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1317, 334);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // TxbPesquisa3
            // 
            this.TxbPesquisa3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(115)))), ((int)(((byte)(151)))));
            this.TxbPesquisa3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbPesquisa3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbPesquisa3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.TxbPesquisa3.Location = new System.Drawing.Point(849, 217);
            this.TxbPesquisa3.Multiline = true;
            this.TxbPesquisa3.Name = "TxbPesquisa3";
            this.TxbPesquisa3.Size = new System.Drawing.Size(490, 56);
            this.TxbPesquisa3.TabIndex = 13;
            // 
            // AdicionarCursoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.TxbPesquisa3);
            this.Controls.Add(this.BtnSaveCourse);
            this.Controls.Add(this.LblTable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnAddCourse);
            this.Controls.Add(this.TxbCargaHoraria);
            this.Controls.Add(this.TxbNomeCurso);
            this.Controls.Add(this.LblCargaHoraria);
            this.Controls.Add(this.LblNomedoCurso);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdicionarCursoControl";
            this.Size = new System.Drawing.Size(1940, 1100);
            this.Load += new System.EventHandler(this.AdicionarCursoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNomedoCurso;
        private System.Windows.Forms.Label LblCargaHoraria;
        private System.Windows.Forms.TextBox TxbNomeCurso;
        private System.Windows.Forms.TextBox TxbCargaHoraria;
        private System.Windows.Forms.Button BtnAddCourse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblTable;
        private System.Windows.Forms.Button BtnSaveCourse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxbPesquisa3;
    }
}
