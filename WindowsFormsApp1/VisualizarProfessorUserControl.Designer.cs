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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProfessores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProfessores
            // 
            this.dataGridViewProfessores.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewProfessores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewProfessores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProfessores.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProfessores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewProfessores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProfessores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProfessores.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewProfessores.EnableHeadersVisualStyles = false;
            this.dataGridViewProfessores.GridColor = System.Drawing.Color.LightCyan;
            this.dataGridViewProfessores.Location = new System.Drawing.Point(214, 245);
            this.dataGridViewProfessores.Name = "dataGridViewProfessores";
            this.dataGridViewProfessores.RowHeadersVisible = false;
            this.dataGridViewProfessores.RowHeadersWidth = 28;
            this.dataGridViewProfessores.Size = new System.Drawing.Size(490, 367);
            this.dataGridViewProfessores.TabIndex = 15;
            // 
            // VizualizarProfessorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewProfessores);
            this.Name = "VizualizarProfessorUserControl";
            this.Size = new System.Drawing.Size(1940, 1100);
            this.Load += new System.EventHandler(this.VisualizarProfessorUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProfessores;
    }
}
