﻿namespace WindowsFormsApp1
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
            this.LblNomedoCurso = new System.Windows.Forms.Label();
            this.LblCargaHoraria = new System.Windows.Forms.Label();
            this.TxbNomeCurso = new System.Windows.Forms.TextBox();
            this.TxbCargaHoraria = new System.Windows.Forms.TextBox();
            this.BtnAddCourse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblTable = new System.Windows.Forms.Label();
            this.BtnSaveCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNomedoCurso
            // 
            this.LblNomedoCurso.AutoSize = true;
            this.LblNomedoCurso.Font = new System.Drawing.Font("Swis721 Blk BT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomedoCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            this.LblNomedoCurso.Location = new System.Drawing.Point(67, 353);
            this.LblNomedoCurso.Name = "LblNomedoCurso";
            this.LblNomedoCurso.Size = new System.Drawing.Size(532, 34);
            this.LblNomedoCurso.TabIndex = 0;
            this.LblNomedoCurso.Text = "Digite o nome do curso/disciplina:";
            // 
            // LblCargaHoraria
            // 
            this.LblCargaHoraria.AutoSize = true;
            this.LblCargaHoraria.Font = new System.Drawing.Font("Swis721 Blk BT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargaHoraria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            this.LblCargaHoraria.Location = new System.Drawing.Point(67, 471);
            this.LblCargaHoraria.Name = "LblCargaHoraria";
            this.LblCargaHoraria.Size = new System.Drawing.Size(495, 34);
            this.LblCargaHoraria.TabIndex = 1;
            this.LblCargaHoraria.Text = "Carga horária do curso (horas):";
            this.LblCargaHoraria.Click += new System.EventHandler(this.LblCargaHoraria_Click);
            // 
            // TxbNomeCurso
            // 
            this.TxbNomeCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            this.TxbNomeCurso.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F);
            this.TxbNomeCurso.ForeColor = System.Drawing.Color.Black;
            this.TxbNomeCurso.Location = new System.Drawing.Point(73, 390);
            this.TxbNomeCurso.Multiline = true;
            this.TxbNomeCurso.Name = "TxbNomeCurso";
            this.TxbNomeCurso.Size = new System.Drawing.Size(626, 54);
            this.TxbNomeCurso.TabIndex = 2;
            // 
            // TxbCargaHoraria
            // 
            this.TxbCargaHoraria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            this.TxbCargaHoraria.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F);
            this.TxbCargaHoraria.ForeColor = System.Drawing.Color.Black;
            this.TxbCargaHoraria.Location = new System.Drawing.Point(73, 508);
            this.TxbCargaHoraria.Multiline = true;
            this.TxbCargaHoraria.Name = "TxbCargaHoraria";
            this.TxbCargaHoraria.Size = new System.Drawing.Size(626, 54);
            this.TxbCargaHoraria.TabIndex = 3;
            // 
            // BtnAddCourse
            // 
            this.BtnAddCourse.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnAddCourse.Font = new System.Drawing.Font("Swis721 Blk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCourse.Location = new System.Drawing.Point(209, 685);
            this.BtnAddCourse.Name = "BtnAddCourse";
            this.BtnAddCourse.Size = new System.Drawing.Size(363, 50);
            this.BtnAddCourse.TabIndex = 4;
            this.BtnAddCourse.Text = "+ ADICIONAR CURSO";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.dataGridView1.Location = new System.Drawing.Point(861, 321);
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
            this.LblTable.Font = new System.Drawing.Font("Swis721 Blk BT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            this.LblTable.Location = new System.Drawing.Point(855, 239);
            this.LblTable.Name = "LblTable";
            this.LblTable.Size = new System.Drawing.Size(496, 68);
            this.LblTable.TabIndex = 6;
            this.LblTable.Text = "Verifique se esse curso já foi\r\ncadastrado (se sim, selecione):";
            // 
            // BtnSaveCourse
            // 
            this.BtnSaveCourse.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSaveCourse.Font = new System.Drawing.Font("Swis721 Blk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveCourse.Location = new System.Drawing.Point(1010, 685);
            this.BtnSaveCourse.Name = "BtnSaveCourse";
            this.BtnSaveCourse.Size = new System.Drawing.Size(198, 50);
            this.BtnSaveCourse.TabIndex = 7;
            this.BtnSaveCourse.Text = "SALVAR";
            this.BtnSaveCourse.UseVisualStyleBackColor = false;
            this.BtnSaveCourse.Click += new System.EventHandler(this.BtnSaveCourse_Click);
            // 
            // AdicionarCursoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnSaveCourse);
            this.Controls.Add(this.LblTable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnAddCourse);
            this.Controls.Add(this.TxbCargaHoraria);
            this.Controls.Add(this.TxbNomeCurso);
            this.Controls.Add(this.LblCargaHoraria);
            this.Controls.Add(this.LblNomedoCurso);
            this.Name = "AdicionarCursoControl";
            this.Size = new System.Drawing.Size(1940, 1100);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}
