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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarAulasUserControl));
            this.CmbCurso = new System.Windows.Forms.ComboBox();
            this.LstAlunos = new System.Windows.Forms.ListBox();
            this.DtPickerDataAula = new System.Windows.Forms.DateTimePicker();
            this.TxbHoraAula = new System.Windows.Forms.MaskedTextBox();
            this.BtnSalvarAula = new System.Windows.Forms.Button();
            this.btnGerarLinkMeet = new System.Windows.Forms.Button();
            this.txtLinkMeet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmbCurso
            // 
            this.CmbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CmbCurso.FormattingEnabled = true;
            this.CmbCurso.Location = new System.Drawing.Point(108, 89);
            this.CmbCurso.Name = "CmbCurso";
            this.CmbCurso.Size = new System.Drawing.Size(416, 33);
            this.CmbCurso.TabIndex = 4;
            this.CmbCurso.SelectedIndexChanged += new System.EventHandler(this.CmbCurso_SelectedIndexChanged);
            // 
            // LstAlunos
            // 
            this.LstAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LstAlunos.FormattingEnabled = true;
            this.LstAlunos.ItemHeight = 25;
            this.LstAlunos.Location = new System.Drawing.Point(108, 230);
            this.LstAlunos.Name = "LstAlunos";
            this.LstAlunos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LstAlunos.Size = new System.Drawing.Size(162, 129);
            this.LstAlunos.TabIndex = 5;
            // 
            // DtPickerDataAula
            // 
            this.DtPickerDataAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DtPickerDataAula.Location = new System.Drawing.Point(108, 478);
            this.DtPickerDataAula.Name = "DtPickerDataAula";
            this.DtPickerDataAula.Size = new System.Drawing.Size(568, 30);
            this.DtPickerDataAula.TabIndex = 6;
            this.DtPickerDataAula.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // TxbHoraAula
            // 
            this.TxbHoraAula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxbHoraAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.TxbHoraAula.Location = new System.Drawing.Point(127, 620);
            this.TxbHoraAula.Name = "TxbHoraAula";
            this.TxbHoraAula.Size = new System.Drawing.Size(549, 33);
            this.TxbHoraAula.TabIndex = 7;
            // 
            // BtnSalvarAula
            // 
            this.BtnSalvarAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(115)))), ((int)(((byte)(151)))));
            this.BtnSalvarAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.BtnSalvarAula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.BtnSalvarAula.Location = new System.Drawing.Point(108, 892);
            this.BtnSalvarAula.Name = "BtnSalvarAula";
            this.BtnSalvarAula.Size = new System.Drawing.Size(191, 53);
            this.BtnSalvarAula.TabIndex = 8;
            this.BtnSalvarAula.Text = "Salvar";
            this.BtnSalvarAula.UseVisualStyleBackColor = false;
            this.BtnSalvarAula.Click += new System.EventHandler(this.BtnSalvarAula_Click);
            // 
            // btnGerarLinkMeet
            // 
            this.btnGerarLinkMeet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(115)))), ((int)(((byte)(151)))));
            this.btnGerarLinkMeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.btnGerarLinkMeet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.btnGerarLinkMeet.Location = new System.Drawing.Point(108, 705);
            this.btnGerarLinkMeet.Name = "btnGerarLinkMeet";
            this.btnGerarLinkMeet.Size = new System.Drawing.Size(354, 53);
            this.btnGerarLinkMeet.TabIndex = 9;
            this.btnGerarLinkMeet.Text = "Gerar Link do Meet";
            this.btnGerarLinkMeet.UseVisualStyleBackColor = false;
            this.btnGerarLinkMeet.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLinkMeet
            // 
            this.txtLinkMeet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLinkMeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.txtLinkMeet.Location = new System.Drawing.Point(127, 809);
            this.txtLinkMeet.Multiline = true;
            this.txtLinkMeet.Name = "txtLinkMeet";
            this.txtLinkMeet.Size = new System.Drawing.Size(577, 37);
            this.txtLinkMeet.TabIndex = 10;
            // 
            // AdicionarAulasUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.txtLinkMeet);
            this.Controls.Add(this.btnGerarLinkMeet);
            this.Controls.Add(this.BtnSalvarAula);
            this.Controls.Add(this.TxbHoraAula);
            this.Controls.Add(this.DtPickerDataAula);
            this.Controls.Add(this.LstAlunos);
            this.Controls.Add(this.CmbCurso);
            this.Name = "AdicionarAulasUserControl";
            this.Size = new System.Drawing.Size(1940, 1100);
            this.Load += new System.EventHandler(this.AdicionarAulasUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbCurso;
        private System.Windows.Forms.ListBox LstAlunos;
        private System.Windows.Forms.DateTimePicker DtPickerDataAula;
        private System.Windows.Forms.MaskedTextBox TxbHoraAula;
        private System.Windows.Forms.Button BtnSalvarAula;
        private System.Windows.Forms.Button btnGerarLinkMeet;
        private System.Windows.Forms.TextBox txtLinkMeet;
    }
}
