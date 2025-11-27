namespace WindowsFormsApp1
{
    partial class VisualizarProfessorUserControl
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
            this.dataGridViewProfessores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProfessores
            // 
            this.dataGridViewProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfessores.Location = new System.Drawing.Point(214, 260);
            this.dataGridViewProfessores.Name = "dataGridViewProfessores";
            this.dataGridViewProfessores.Size = new System.Drawing.Size(489, 365);
            this.dataGridViewProfessores.TabIndex = 16;
            // 
            // VisualizarProfessorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProfessores);
            this.Name = "VisualizarProfessorUserControl";
            this.Size = new System.Drawing.Size(1940, 1100);
            this.Load += new System.EventHandler(this.VisualizarProfessorUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProfessores;
    }
}
