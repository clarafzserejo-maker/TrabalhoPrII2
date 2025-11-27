namespace WindowsFormsApp1
{
    partial class VerBoletimProfUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerBoletimProfUserControl));
            this.CmbAluno = new System.Windows.Forms.ComboBox();
            this.DgvBoletim = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBoletim)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbAluno
            // 
            this.CmbAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CmbAluno.FormattingEnabled = true;
            this.CmbAluno.Location = new System.Drawing.Point(106, 264);
            this.CmbAluno.Name = "CmbAluno";
            this.CmbAluno.Size = new System.Drawing.Size(416, 33);
            this.CmbAluno.TabIndex = 5;
            // 
            // DgvBoletim
            // 
            this.DgvBoletim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBoletim.Location = new System.Drawing.Point(106, 318);
            this.DgvBoletim.Name = "DgvBoletim";
            this.DgvBoletim.Size = new System.Drawing.Size(725, 272);
            this.DgvBoletim.TabIndex = 6;
            // 
            // VerBoletimProfUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.DgvBoletim);
            this.Controls.Add(this.CmbAluno);
            this.Name = "VerBoletimProfUserControl";
            this.Size = new System.Drawing.Size(1940, 1100);
            this.Load += new System.EventHandler(this.VerBoletimProfUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBoletim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbAluno;
        private System.Windows.Forms.DataGridView DgvBoletim;
    }
}
