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
            this.LblSelecionarAula = new System.Windows.Forms.Label();
            this.CmbAlunoNotas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbNotas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSalvarNotas = new System.Windows.Forms.Button();
            this.DomNota = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbDisciplina = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblSelecionarAula
            // 
            this.LblSelecionarAula.AutoSize = true;
            this.LblSelecionarAula.Location = new System.Drawing.Point(15, 54);
            this.LblSelecionarAula.Name = "LblSelecionarAula";
            this.LblSelecionarAula.Size = new System.Drawing.Size(214, 13);
            this.LblSelecionarAula.TabIndex = 2;
            this.LblSelecionarAula.Text = "Selecione um aluno para atualizar o boletim:";
            // 
            // CmbAlunoNotas
            // 
            this.CmbAlunoNotas.FormattingEnabled = true;
            this.CmbAlunoNotas.Location = new System.Drawing.Point(18, 70);
            this.CmbAlunoNotas.Name = "CmbAlunoNotas";
            this.CmbAlunoNotas.Size = new System.Drawing.Size(121, 21);
            this.CmbAlunoNotas.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecione uma nota para atualizar:";
            // 
            // CmbNotas
            // 
            this.CmbNotas.FormattingEnabled = true;
            this.CmbNotas.Location = new System.Drawing.Point(18, 183);
            this.CmbNotas.Name = "CmbNotas";
            this.CmbNotas.Size = new System.Drawing.Size(121, 21);
            this.CmbNotas.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Adicione a nova nota:";
            // 
            // BtnSalvarNotas
            // 
            this.BtnSalvarNotas.Location = new System.Drawing.Point(18, 284);
            this.BtnSalvarNotas.Name = "BtnSalvarNotas";
            this.BtnSalvarNotas.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvarNotas.TabIndex = 10;
            this.BtnSalvarNotas.Text = "Salvar";
            this.BtnSalvarNotas.UseVisualStyleBackColor = true;
            // 
            // DomNota
            // 
            this.DomNota.Location = new System.Drawing.Point(19, 244);
            this.DomNota.Name = "DomNota";
            this.DomNota.Size = new System.Drawing.Size(120, 20);
            this.DomNota.TabIndex = 11;
            this.DomNota.Text = "domainUpDown1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Selecione uma disciplina:";
            // 
            // CmbDisciplina
            // 
            this.CmbDisciplina.FormattingEnabled = true;
            this.CmbDisciplina.Location = new System.Drawing.Point(18, 121);
            this.CmbDisciplina.Name = "CmbDisciplina";
            this.CmbDisciplina.Size = new System.Drawing.Size(121, 21);
            this.CmbDisciplina.TabIndex = 13;
            // 
            // AdicionarNotasUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CmbDisciplina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DomNota);
            this.Controls.Add(this.BtnSalvarNotas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbNotas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbAlunoNotas);
            this.Controls.Add(this.LblSelecionarAula);
            this.Name = "AdicionarNotasUserControl";
            this.Size = new System.Drawing.Size(1940, 1100);
            this.Load += new System.EventHandler(this.AdicionarNotasUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSelecionarAula;
        private System.Windows.Forms.ComboBox CmbAlunoNotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbNotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSalvarNotas;
        private System.Windows.Forms.DomainUpDown DomNota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbDisciplina;
    }
}
