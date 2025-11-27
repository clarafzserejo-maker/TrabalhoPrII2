namespace WindowsFormsApp1
{
    partial class AdicionarCursoAlunoUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarCursoAlunoUserControl));
            this.BtnNewCourse = new System.Windows.Forms.Button();
            this.TxbPesquisa = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNewCourse
            // 
            this.BtnNewCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(125)))));
            this.BtnNewCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.BtnNewCourse.Location = new System.Drawing.Point(589, 680);
            this.BtnNewCourse.Name = "BtnNewCourse";
            this.BtnNewCourse.Size = new System.Drawing.Size(265, 51);
            this.BtnNewCourse.TabIndex = 8;
            this.BtnNewCourse.Text = "+ Matricular";
            this.BtnNewCourse.UseVisualStyleBackColor = false;
            this.BtnNewCourse.Click += new System.EventHandler(this.BtnNewCourse_Click);
            // 
            // TxbPesquisa
            // 
            this.TxbPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(115)))), ((int)(((byte)(151)))));
            this.TxbPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.TxbPesquisa.Location = new System.Drawing.Point(481, 235);
            this.TxbPesquisa.Multiline = true;
            this.TxbPesquisa.Name = "TxbPesquisa";
            this.TxbPesquisa.Size = new System.Drawing.Size(490, 56);
            this.TxbPesquisa.TabIndex = 9;
            this.TxbPesquisa.TextChanged += new System.EventHandler(this.TxbPesquisa_TextChanged_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-281, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1333, 344);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(475, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 311);
            this.dataGridView1.TabIndex = 11;
            // 
            // AdicionarCursoAlunoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxbPesquisa);
            this.Controls.Add(this.BtnNewCourse);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdicionarCursoAlunoUserControl";
            this.Size = new System.Drawing.Size(1940, 1100);
            this.Load += new System.EventHandler(this.AdicionarCursoAlunoUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnNewCourse;
        private System.Windows.Forms.TextBox TxbPesquisa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
