namespace WindowsFormsApp1
{
    partial class AdicionarNotasUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarNotasUserControl));
            this.CmbAlunoNotas = new System.Windows.Forms.ComboBox();
            this.CmbNotas = new System.Windows.Forms.ComboBox();
            this.BtnSalvarNotas = new System.Windows.Forms.Button();
            this.DomNota = new System.Windows.Forms.DomainUpDown();
            this.CmbDisciplina = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CmbAlunoNotas
            // 
            this.CmbAlunoNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CmbAlunoNotas.FormattingEnabled = true;
            this.CmbAlunoNotas.Location = new System.Drawing.Point(108, 270);
            this.CmbAlunoNotas.Name = "CmbAlunoNotas";
            this.CmbAlunoNotas.Size = new System.Drawing.Size(416, 33);
            this.CmbAlunoNotas.TabIndex = 6;
            // 
            // CmbNotas
            // 
            this.CmbNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CmbNotas.FormattingEnabled = true;
            this.CmbNotas.Location = new System.Drawing.Point(108, 552);
            this.CmbNotas.Name = "CmbNotas";
            this.CmbNotas.Size = new System.Drawing.Size(416, 33);
            this.CmbNotas.TabIndex = 8;
            // 
            // BtnSalvarNotas
            // 
            this.BtnSalvarNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(115)))), ((int)(((byte)(151)))));
            this.BtnSalvarNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.BtnSalvarNotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.BtnSalvarNotas.Location = new System.Drawing.Point(110, 757);
            this.BtnSalvarNotas.Name = "BtnSalvarNotas";
            this.BtnSalvarNotas.Size = new System.Drawing.Size(191, 53);
            this.BtnSalvarNotas.TabIndex = 10;
            this.BtnSalvarNotas.Text = "Salvar";
            this.BtnSalvarNotas.UseVisualStyleBackColor = false;
            // 
            // DomNota
            // 
            this.DomNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DomNota.Location = new System.Drawing.Point(108, 699);
            this.DomNota.Name = "DomNota";
            this.DomNota.Size = new System.Drawing.Size(189, 30);
            this.DomNota.TabIndex = 11;
            this.DomNota.Text = "domainUpDown1";
            // 
            // CmbDisciplina
            // 
            this.CmbDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CmbDisciplina.FormattingEnabled = true;
            this.CmbDisciplina.Location = new System.Drawing.Point(108, 410);
            this.CmbDisciplina.Name = "CmbDisciplina";
            this.CmbDisciplina.Size = new System.Drawing.Size(416, 33);
            this.CmbDisciplina.TabIndex = 13;
            // 
            // AdicionarNotasUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.CmbDisciplina);
            this.Controls.Add(this.DomNota);
            this.Controls.Add(this.BtnSalvarNotas);
            this.Controls.Add(this.CmbNotas);
            this.Controls.Add(this.CmbAlunoNotas);
            this.Name = "AdicionarNotasUserControl";
            this.Size = new System.Drawing.Size(1940, 1100);
            this.Load += new System.EventHandler(this.AdicionarNotasUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbAlunoNotas;
        private System.Windows.Forms.ComboBox CmbNotas;
        private System.Windows.Forms.Button BtnSalvarNotas;
        private System.Windows.Forms.DomainUpDown DomNota;
        private System.Windows.Forms.ComboBox CmbDisciplina;
    }
}
