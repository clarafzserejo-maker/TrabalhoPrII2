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
            this.LblSelecionarAula = new System.Windows.Forms.Label();
            this.CmbAluno = new System.Windows.Forms.ComboBox();
            this.DgvBoletim = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBoletim)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSelecionarAula
            // 
            this.LblSelecionarAula.AutoSize = true;
            this.LblSelecionarAula.Location = new System.Drawing.Point(27, 76);
            this.LblSelecionarAula.Name = "LblSelecionarAula";
            this.LblSelecionarAula.Size = new System.Drawing.Size(212, 13);
            this.LblSelecionarAula.TabIndex = 1;
            this.LblSelecionarAula.Text = "Selecione um aluno para acessar o boletim:";
            // 
            // CmbAluno
            // 
            this.CmbAluno.FormattingEnabled = true;
            this.CmbAluno.Location = new System.Drawing.Point(30, 92);
            this.CmbAluno.Name = "CmbAluno";
            this.CmbAluno.Size = new System.Drawing.Size(121, 21);
            this.CmbAluno.TabIndex = 5;
            // 
            // DgvBoletim
            // 
            this.DgvBoletim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBoletim.Location = new System.Drawing.Point(30, 131);
            this.DgvBoletim.Name = "DgvBoletim";
            this.DgvBoletim.Size = new System.Drawing.Size(479, 272);
            this.DgvBoletim.TabIndex = 6;
            // 
            // VerBoletimProfUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DgvBoletim);
            this.Controls.Add(this.CmbAluno);
            this.Controls.Add(this.LblSelecionarAula);
            this.Name = "VerBoletimProfUserControl";
            this.Size = new System.Drawing.Size(1940, 1100);
            this.Load += new System.EventHandler(this.VerBoletimProfUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBoletim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSelecionarAula;
        private System.Windows.Forms.ComboBox CmbAluno;
        private System.Windows.Forms.DataGridView DgvBoletim;
    }
}
