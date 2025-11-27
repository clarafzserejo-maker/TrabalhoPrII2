namespace WindowsFormsApp1
{
    partial class VerCursosAlunoUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerCursosAlunoUserControl));
            this.LblSemCurso = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxbPesquisa2 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSemCurso
            // 
            this.LblSemCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSemCurso.AutoSize = true;
            this.LblSemCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSemCurso.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblSemCurso.Location = new System.Drawing.Point(503, 492);
            this.LblSemCurso.Name = "LblSemCurso";
            this.LblSemCurso.Size = new System.Drawing.Size(533, 39);
            this.LblSemCurso.TabIndex = 1;
            this.LblSemCurso.Text = "Não existem cursos cadastrados.";
            this.LblSemCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblSemCurso.Click += new System.EventHandler(this.LblSemCurso_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-542, -90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1333, 344);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TxbPesquisa2
            // 
            this.TxbPesquisa2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(115)))), ((int)(((byte)(151)))));
            this.TxbPesquisa2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbPesquisa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbPesquisa2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.TxbPesquisa2.Location = new System.Drawing.Point(214, 155);
            this.TxbPesquisa2.Multiline = true;
            this.TxbPesquisa2.Name = "TxbPesquisa2";
            this.TxbPesquisa2.Size = new System.Drawing.Size(490, 56);
            this.TxbPesquisa2.TabIndex = 12;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(214, 260);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(484, 366);
            this.dataGridView3.TabIndex = 14;
            // 
            // VerCursosAlunoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.TxbPesquisa2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblSemCurso);
            this.Name = "VerCursosAlunoUserControl";
            this.Size = new System.Drawing.Size(1940, 1100);
            this.Load += new System.EventHandler(this.VerCursosAlunoUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSemCurso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxbPesquisa2;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}
