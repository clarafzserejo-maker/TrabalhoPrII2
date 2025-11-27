namespace WindowsFormsApp1
{
    partial class TodosOsAlunosUserControl
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
            this.dataGridViewTodosOsAlunos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodosOsAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTodosOsAlunos
            // 
            this.dataGridViewTodosOsAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTodosOsAlunos.Location = new System.Drawing.Point(216, 260);
            this.dataGridViewTodosOsAlunos.Name = "dataGridViewTodosOsAlunos";
            this.dataGridViewTodosOsAlunos.Size = new System.Drawing.Size(490, 367);
            this.dataGridViewTodosOsAlunos.TabIndex = 16;
            // 
            // TodosOsAlunosUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewTodosOsAlunos);
            this.Name = "TodosOsAlunosUserControl";
            this.Size = new System.Drawing.Size(1940, 1100);
            this.Load += new System.EventHandler(this.TodosOsAlunosUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodosOsAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTodosOsAlunos;
    }
}
