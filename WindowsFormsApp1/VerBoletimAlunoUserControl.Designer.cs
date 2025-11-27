namespace WindowsFormsApp1
{
    partial class VerBoletimAlunoUserControl
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
            this.DgvBoletim2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBoletim2)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvBoletim2
            // 
            this.DgvBoletim2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBoletim2.Location = new System.Drawing.Point(106, 318);
            this.DgvBoletim2.Name = "DgvBoletim2";
            this.DgvBoletim2.Size = new System.Drawing.Size(724, 272);
            this.DgvBoletim2.TabIndex = 7;
            // 
            // VerBoletimAlunoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DgvBoletim2);
            this.Name = "VerBoletimAlunoUserControl";
            this.Size = new System.Drawing.Size(1940, 1100);
            this.Load += new System.EventHandler(this.VerBoletimAlunoUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBoletim2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBoletim2;
    }
}
