namespace WindowsFormsApp1
{
    partial class AdicionarCursoControl
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
            this.LblNomedoCurso = new System.Windows.Forms.Label();
            this.LblCargaHoraria = new System.Windows.Forms.Label();
            this.TxbNomeCurso = new System.Windows.Forms.TextBox();
            this.TxbCargaHoraria = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNomedoCurso
            // 
            this.LblNomedoCurso.AutoSize = true;
            this.LblNomedoCurso.Font = new System.Drawing.Font("Swis721 Blk BT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomedoCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            this.LblNomedoCurso.Location = new System.Drawing.Point(3, 273);
            this.LblNomedoCurso.Name = "LblNomedoCurso";
            this.LblNomedoCurso.Size = new System.Drawing.Size(532, 34);
            this.LblNomedoCurso.TabIndex = 0;
            this.LblNomedoCurso.Text = "Digite o nome do curso/disciplina:";
            // 
            // LblCargaHoraria
            // 
            this.LblCargaHoraria.AutoSize = true;
            this.LblCargaHoraria.Font = new System.Drawing.Font("Swis721 Blk BT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargaHoraria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            this.LblCargaHoraria.Location = new System.Drawing.Point(3, 391);
            this.LblCargaHoraria.Name = "LblCargaHoraria";
            this.LblCargaHoraria.Size = new System.Drawing.Size(376, 34);
            this.LblCargaHoraria.TabIndex = 1;
            this.LblCargaHoraria.Text = "Carga horária do curso:";
            // 
            // TxbNomeCurso
            // 
            this.TxbNomeCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            this.TxbNomeCurso.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F);
            this.TxbNomeCurso.ForeColor = System.Drawing.Color.Black;
            this.TxbNomeCurso.Location = new System.Drawing.Point(9, 310);
            this.TxbNomeCurso.Multiline = true;
            this.TxbNomeCurso.Name = "TxbNomeCurso";
            this.TxbNomeCurso.Size = new System.Drawing.Size(626, 54);
            this.TxbNomeCurso.TabIndex = 2;
            // 
            // TxbCargaHoraria
            // 
            this.TxbCargaHoraria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(188)))), ((int)(((byte)(199)))));
            this.TxbCargaHoraria.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F);
            this.TxbCargaHoraria.ForeColor = System.Drawing.Color.Black;
            this.TxbCargaHoraria.Location = new System.Drawing.Point(9, 428);
            this.TxbCargaHoraria.Multiline = true;
            this.TxbCargaHoraria.Name = "TxbCargaHoraria";
            this.TxbCargaHoraria.Size = new System.Drawing.Size(626, 54);
            this.TxbCargaHoraria.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("Swis721 Blk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(145, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(363, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "+ ADICIONAR CURSO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AdicionarCursoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxbCargaHoraria);
            this.Controls.Add(this.TxbNomeCurso);
            this.Controls.Add(this.LblCargaHoraria);
            this.Controls.Add(this.LblNomedoCurso);
            this.Name = "AdicionarCursoControl";
            this.Size = new System.Drawing.Size(1940, 1100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNomedoCurso;
        private System.Windows.Forms.Label LblCargaHoraria;
        private System.Windows.Forms.TextBox TxbNomeCurso;
        private System.Windows.Forms.TextBox TxbCargaHoraria;
        private System.Windows.Forms.Button button1;
    }
}
