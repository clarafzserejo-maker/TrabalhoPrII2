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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblSemCurso = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSemCurso
            // 
            this.LblSemCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSemCurso.AutoSize = true;
            this.LblSemCurso.Font = new System.Drawing.Font("Swis721 Blk BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSemCurso.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblSemCurso.Location = new System.Drawing.Point(503, 492);
            this.LblSemCurso.Name = "LblSemCurso";
            this.LblSemCurso.Size = new System.Drawing.Size(659, 42);
            this.LblSemCurso.TabIndex = 1;
            this.LblSemCurso.Text = "Não existem cursos cadastrados.";
            this.LblSemCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightCyan;
            this.dataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.Location = new System.Drawing.Point(42, 273);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 28;
            this.dataGridView3.Size = new System.Drawing.Size(548, 380);
            this.dataGridView3.TabIndex = 2;
            // 
            // VerCursosAlunoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.LblSemCurso);
            this.Name = "VerCursosAlunoUserControl";
            this.Size = new System.Drawing.Size(1940, 1100);
            this.Load += new System.EventHandler(this.VerCursosAlunoUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSemCurso;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}
