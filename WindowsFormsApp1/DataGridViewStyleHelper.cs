using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // Classe auxiliar estática para aplicar estilos consistentes aos DataGridViews
    public static class DataGridViewStyleHelper
    {
        public static void AplicarEstiloPadrao(DataGridView dgv)
        {
            if (dgv == null) return;

            // 1. Configurações Gerais do DataGridView
            dgv.BackgroundColor = Color.WhiteSmoke;
            dgv.BorderStyle = BorderStyle.None;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.RowHeadersVisible = false; // Remove a coluna da esquerda (seta de seleção) para um look mais limpo
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // 2. Estilo do Cabeçalho (Header)
            Color headerBackColor = ColorTranslator.FromHtml("#6A5ACD"); // Roxo/Lavanda Escuro
            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerBackColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold); // Negrito, conforme solicitado
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.EnableHeadersVisualStyles = false; // Necessário para aplicar estilos personalizados
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 3. Estilo das Células (Dados)
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            // Cor de seleção mais clara, como um cinza suave (#D0D0D0)
            dgv.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#D0D0D0");
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // 4. Estilo de Linhas Alternadas (Melhora a leitura)
            dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F0F0F0"); // Cinza muito claro

            // 5. Garantir que os nomes das colunas estejam em MAIÚSCULAS E REFORÇAR O ESTILO DO CABEÇALHO
            dgv.DataBindingComplete += (sender, e) =>
            {
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    // Assegura que o texto do cabeçalho está em maiúsculas
                    column.HeaderText = column.HeaderText.ToUpper();

                    // REFORÇO CRÍTICO: Sobrescreve qualquer estilo individual de cabeçalho
                    // para garantir que a cor de fundo seja a padrão (Roxo/Lavanda)
                    column.HeaderCell.Style.BackColor = headerBackColor;
                    column.HeaderCell.Style.ForeColor = Color.White;
                }
            };
        }
    }
}