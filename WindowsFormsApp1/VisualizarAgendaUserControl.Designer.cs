namespace WindowsFormsApp1
{
    partial class VisualizarAgendaUserControl
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.DgvAgenda = new System.Windows.Forms.DataGridView();
            this.btnExcluirAula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(26, 24);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // DgvAgenda
            // 
            this.DgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAgenda.Location = new System.Drawing.Point(26, 222);
            this.DgvAgenda.Name = "DgvAgenda";
            this.DgvAgenda.Size = new System.Drawing.Size(479, 272);
            this.DgvAgenda.TabIndex = 1;
            // 
            // btnExcluirAula
            // 
            this.btnExcluirAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(125)))));
            this.btnExcluirAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.btnExcluirAula.Location = new System.Drawing.Point(161, 500);
            this.btnExcluirAula.Name = "btnExcluirAula";
            this.btnExcluirAula.Size = new System.Drawing.Size(179, 51);
            this.btnExcluirAula.TabIndex = 9;
            this.btnExcluirAula.Text = "Excluir Aula";
            this.btnExcluirAula.UseVisualStyleBackColor = false;
            this.btnExcluirAula.Click += new System.EventHandler(this.BtnNewCourse_Click);
            // 
            // VisualizarAgendaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExcluirAula);
            this.Controls.Add(this.DgvAgenda);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "VisualizarAgendaUserControl";
            this.Size = new System.Drawing.Size(1940, 1100);
            this.Load += new System.EventHandler(this.VisualizarAgendaUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView DgvAgenda;
        private System.Windows.Forms.Button btnExcluirAula;
    }
}
