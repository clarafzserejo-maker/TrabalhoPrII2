namespace WindowsFormsApp1
{
    partial class AdicionarAulasUserControl
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
            this.LblSelecionarAluno = new System.Windows.Forms.Label();
            this.LblData = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.CmbCurso = new System.Windows.Forms.ComboBox();
            this.LstAlunos = new System.Windows.Forms.ListBox();
            this.DtPickerDataAula = new System.Windows.Forms.DateTimePicker();
            this.TxbHoraAula = new System.Windows.Forms.MaskedTextBox();
            this.BtnSalvarAula = new System.Windows.Forms.Button();
            this.btnGerarLinkMeet = new System.Windows.Forms.Button();
            this.txtLinkMeet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblSelecionarAula
            // 
            this.LblSelecionarAula.AutoSize = true;
            this.LblSelecionarAula.Location = new System.Drawing.Point(26, 89);
            this.LblSelecionarAula.Name = "LblSelecionarAula";
            this.LblSelecionarAula.Size = new System.Drawing.Size(95, 13);
            this.LblSelecionarAula.TabIndex = 0;
            this.LblSelecionarAula.Text = "Selecione o curso:";
            // 
            // LblSelecionarAluno
            // 
            this.LblSelecionarAluno.AutoSize = true;
            this.LblSelecionarAluno.Location = new System.Drawing.Point(26, 139);
            this.LblSelecionarAluno.Name = "LblSelecionarAluno";
            this.LblSelecionarAluno.Size = new System.Drawing.Size(117, 13);
            this.LblSelecionarAluno.TabIndex = 1;
            this.LblSelecionarAluno.Text = "Selecione o(s) aluno(s):";
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Location = new System.Drawing.Point(26, 266);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(90, 13);
            this.LblData.TabIndex = 2;
            this.LblData.Text = "Selecione a data:";
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Location = new System.Drawing.Point(26, 309);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(167, 13);
            this.LblHora.TabIndex = 3;
            this.LblHora.Text = "Digita a hora (formato 24h/00:00):";
            this.LblHora.Click += new System.EventHandler(this.LblHora_Click);
            // 
            // CmbCurso
            // 
            this.CmbCurso.FormattingEnabled = true;
            this.CmbCurso.Location = new System.Drawing.Point(29, 105);
            this.CmbCurso.Name = "CmbCurso";
            this.CmbCurso.Size = new System.Drawing.Size(121, 21);
            this.CmbCurso.TabIndex = 4;
            this.CmbCurso.SelectedIndexChanged += new System.EventHandler(this.CmbCurso_SelectedIndexChanged);
            // 
            // LstAlunos
            // 
            this.LstAlunos.FormattingEnabled = true;
            this.LstAlunos.Location = new System.Drawing.Point(29, 155);
            this.LstAlunos.Name = "LstAlunos";
            this.LstAlunos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LstAlunos.Size = new System.Drawing.Size(120, 95);
            this.LstAlunos.TabIndex = 5;
            // 
            // DtPickerDataAula
            // 
            this.DtPickerDataAula.Location = new System.Drawing.Point(29, 282);
            this.DtPickerDataAula.Name = "DtPickerDataAula";
            this.DtPickerDataAula.Size = new System.Drawing.Size(200, 20);
            this.DtPickerDataAula.TabIndex = 6;
            this.DtPickerDataAula.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TxbHoraAula
            // 
            this.TxbHoraAula.Location = new System.Drawing.Point(29, 325);
            this.TxbHoraAula.Name = "TxbHoraAula";
            this.TxbHoraAula.Size = new System.Drawing.Size(100, 20);
            this.TxbHoraAula.TabIndex = 7;
            // 
            // BtnSalvarAula
            // 
            this.BtnSalvarAula.Location = new System.Drawing.Point(29, 416);
            this.BtnSalvarAula.Name = "BtnSalvarAula";
            this.BtnSalvarAula.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvarAula.TabIndex = 8;
            this.BtnSalvarAula.Text = "Salvar";
            this.BtnSalvarAula.UseVisualStyleBackColor = true;
            this.BtnSalvarAula.Click += new System.EventHandler(this.BtnSalvarAula_Click);
            // 
            // btnGerarLinkMeet
            // 
            this.btnGerarLinkMeet.Location = new System.Drawing.Point(29, 361);
            this.btnGerarLinkMeet.Name = "btnGerarLinkMeet";
            this.btnGerarLinkMeet.Size = new System.Drawing.Size(121, 23);
            this.btnGerarLinkMeet.TabIndex = 9;
            this.btnGerarLinkMeet.Text = "Gerar Link do Meet";
            this.btnGerarLinkMeet.UseVisualStyleBackColor = true;
            this.btnGerarLinkMeet.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLinkMeet
            // 
            this.txtLinkMeet.Location = new System.Drawing.Point(29, 390);
            this.txtLinkMeet.Name = "txtLinkMeet";
            this.txtLinkMeet.Size = new System.Drawing.Size(200, 20);
            this.txtLinkMeet.TabIndex = 10;
            // 
            // AdicionarAulasUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLinkMeet);
            this.Controls.Add(this.btnGerarLinkMeet);
            this.Controls.Add(this.BtnSalvarAula);
            this.Controls.Add(this.TxbHoraAula);
            this.Controls.Add(this.DtPickerDataAula);
            this.Controls.Add(this.LstAlunos);
            this.Controls.Add(this.CmbCurso);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.LblSelecionarAluno);
            this.Controls.Add(this.LblSelecionarAula);
            this.Name = "AdicionarAulasUserControl";
            this.Size = new System.Drawing.Size(1940, 1100);
            this.Load += new System.EventHandler(this.AdicionarAulasUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSelecionarAula;
        private System.Windows.Forms.Label LblSelecionarAluno;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.ComboBox CmbCurso;
        private System.Windows.Forms.ListBox LstAlunos;
        private System.Windows.Forms.DateTimePicker DtPickerDataAula;
        private System.Windows.Forms.MaskedTextBox TxbHoraAula;
        private System.Windows.Forms.Button BtnSalvarAula;
        private System.Windows.Forms.Button btnGerarLinkMeet;
        private System.Windows.Forms.TextBox txtLinkMeet;
    }
}
