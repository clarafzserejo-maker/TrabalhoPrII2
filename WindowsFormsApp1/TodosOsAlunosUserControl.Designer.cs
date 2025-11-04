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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTodosOsAlunos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodosOsAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTodosOsAlunos
            // 
            this.dataGridViewTodosOsAlunos.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewTodosOsAlunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTodosOsAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTodosOsAlunos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTodosOsAlunos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTodosOsAlunos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTodosOsAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTodosOsAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTodosOsAlunos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTodosOsAlunos.EnableHeadersVisualStyles = false;
            this.dataGridViewTodosOsAlunos.GridColor = System.Drawing.Color.LightCyan;
            this.dataGridViewTodosOsAlunos.Location = new System.Drawing.Point(117, 352);
            this.dataGridViewTodosOsAlunos.Name = "dataGridViewTodosOsAlunos";
            this.dataGridViewTodosOsAlunos.RowHeadersVisible = false;
            this.dataGridViewTodosOsAlunos.RowHeadersWidth = 28;
            this.dataGridViewTodosOsAlunos.Size = new System.Drawing.Size(490, 367);
            this.dataGridViewTodosOsAlunos.TabIndex = 15;
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
