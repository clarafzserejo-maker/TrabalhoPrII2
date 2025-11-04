using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjetoProg.Btn;

namespace WindowsFormsApp1
{
    public partial class AdicionarAulasUserControl : UserControl
    {
        // NOTA: Assumindo que LstAlunos, DtPickerDataAula e TxbHoraAula são os nomes dos seus controles.

        public AdicionarAulasUserControl()
        {
            InitializeComponent();
        }

        private void AdicionarAulasUserControl_Load(object sender, EventArgs e)
        {
            CarregarDisciplinas();
        }

        private void CarregarDisciplinas()
        {
            // 1. VERIFICAÇÃO CRÍTICA: Garantir que o ID do usuário não seja nulo/vazio
            string idProfessor = SessaoUsuario.IdUsuario;

            if (string.IsNullOrEmpty(idProfessor))
            {
                MessageBox.Show("Erro de Sessão: ID do professor não encontrado. Faça login novamente.", "Erro de Autorização");
                CmbCurso.DataSource = null; // Limpa o ComboBox
                return; // Sai da função
            }

            string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Usando DISTINCT para evitar duplicação e JOIN explícito
                    string query = @"
                        SELECT DISTINCT 
                            C.ID_CURSO, 
                            C.NOME_CURSO 
                        FROM 
                            CURSOS C
                        INNER JOIN CURSOS_PROFESSORES CP ON C.ID_CURSO = CP.ID_CURSO
                        WHERE 
                            CP.ID_PROFESSOR = @id_usuario 
                        ORDER BY
                            C.NOME_CURSO";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@id_usuario", SqlDbType.NVarChar, 50).Value = idProfessor;

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // Se a consulta retornar dados, carrega no ComboBox
                    if (dt.Rows.Count > 0)
                    {
                        CmbCurso.DisplayMember = "NOME_CURSO";
                        CmbCurso.ValueMember = "ID_CURSO";
                        CmbCurso.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Você não tem cursos associados para agendamento.", "Informação");
                        CmbCurso.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar disciplinas: " + ex.Message, "Erro de Banco de Dados");
                }
            }
        }

        private void CmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tenta localizar a ListBox de alunos no UserControl
            ListBox LstAlunos = this.Controls.Find("LstAlunos", true).FirstOrDefault() as ListBox;

            if (CmbCurso.SelectedValue != null && CmbCurso.SelectedValue != DBNull.Value)
            {
                if (int.TryParse(CmbCurso.SelectedValue.ToString(), out int idCursoSelecionado))
                {
                    CarregarAlunosPorCurso(idCursoSelecionado);
                }
            }
            else
            {
                if (LstAlunos != null)
                {
                    LstAlunos.DataSource = null;
                }
            }
        }


        private void CarregarAlunosPorCurso(int idCurso)
        {
            ListBox LstAlunos = this.Controls.Find("LstAlunos", true).FirstOrDefault() as ListBox;
            if (LstAlunos == null) return;

            string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = @"
                        SELECT 
                            A.ID_ALUNO, 
                            A.NOME_ALUNO
                        FROM 
                            ALUNOS A
                        INNER JOIN ALUNOS_CURSOS AC ON A.ID_ALUNO = AC.ID_ALUNO
                        WHERE 
                            AC.ID_CURSO = @idCurso
                        ORDER BY
                            A.NOME_ALUNO";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@idCurso", idCurso);

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dtAlunos = new DataTable();
                    dtAlunos.Load(reader);

                    LstAlunos.DisplayMember = "NOME_ALUNO"; // Coluna visível
                    LstAlunos.ValueMember = "ID_ALUNO";      // Coluna de valor interno (ID)
                    LstAlunos.DataSource = dtAlunos;

                    if (dtAlunos.Rows.Count == 0)
                    {
                        LstAlunos.DataSource = null;
                        LstAlunos.Items.Clear();
                        LstAlunos.Items.Add("Nenhum aluno neste curso.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar alunos: " + ex.Message, "Erro de Banco de Dados");
                }
            }
        }

        private void LblHora_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalvarAula_Click(object sender, EventArgs e)
        {
            string idProfessorStr = SessaoUsuario.IdUsuario;
            if (string.IsNullOrEmpty(idProfessorStr))
            {
                MessageBox.Show("Erro de sessão. ID do professor não encontrado.", "Erro");
                return;
            }

            // 2. Coletar dados do Curso (ID)
            if (CmbCurso.SelectedValue == null || CmbCurso.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Selecione um curso antes de salvar.", "Aviso");
                return;
            }
            int idCurso = int.Parse(CmbCurso.SelectedValue.ToString());

            // 3. Coletar Alunos Selecionados (IDs Múltiplos) - AGORA COMO STRING
            List<string> idsAlunosSelecionados = new List<string>();

            // Tenta localizar a ListBox de alunos no UserControl
            ListBox LstAlunos = this.Controls.Find("LstAlunos", true).FirstOrDefault() as ListBox;

            if (LstAlunos == null || LstAlunos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um aluno na lista.", "Aviso");
                return;
            }

            // Itera sobre os itens selecionados para extrair o ID_ALUNO (STRING)
            foreach (DataRowView item in LstAlunos.SelectedItems)
            {
                // Apenas coleta o valor como string, sem TryParse
                string idAluno = item["ID_ALUNO"].ToString();

                if (!string.IsNullOrEmpty(idAluno))
                {
                    idsAlunosSelecionados.Add(idAluno);
                }
            }

            if (idsAlunosSelecionados.Count == 0)
            {
                MessageBox.Show("Erro: Nenhum ID de aluno válido foi coletado. Verifique se a coluna ID_ALUNO existe.", "Erro de Coleta de ID");
                return;
            }

            // 4. Coletar Data e Hora
            DateTime dataAula = DtPickerDataAula.Value.Date;
            string horaStr = TxbHoraAula.Text.Trim();

            if (!TimeSpan.TryParse(horaStr, out TimeSpan horaAula))
            {
                MessageBox.Show("Hora inválida. Verifique se o formato é HH:mm (ex: 14:30).", "Aviso");
                return;
            }

            DateTime dataEHora = dataAula.Add(horaAula);

            // 5. Salvar no Banco
            // CHAMADA CORRIGIDA: Passa List<string>
            SalvarAgendamento(idProfessorStr, idCurso, idsAlunosSelecionados, dataEHora);
        }

        // ASSINATURA CORRIGIDA: Agora recebe List<string> para os IDs dos alunos
        private void SalvarAgendamento(string idProfessorStr, int idCurso, List<string> idsAlunos, DateTime dataEHora)
        {
            // O ID do professor JÁ É a string (VARCHAR). Removemos a tentativa de conversão para INT.
            string idProfessor = idProfessorStr;

            // O código de conexão não muda

            string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // Query para inserção na tabela AULAS_AGENDADAS (ID_PROFESSOR é string/VARCHAR)
                    string query = @"
                INSERT INTO AULAS_AGENDADAS (ID_PROFESSOR, ID_ALUNO, ID_CURSO, DATA_HORA)
                VALUES (@idProfessor, @idAluno, @idCurso, @dataHora)";

                    SqlCommand cmd = new SqlCommand(query, con, transaction);

                    // CORREÇÃO: Define o parâmetro ID_PROFESSOR como STRING (NVarChar)
                    cmd.Parameters.Add("@idProfessor", SqlDbType.NVarChar, 50).Value = idProfessor;

                    cmd.Parameters.Add("@idCurso", SqlDbType.Int).Value = idCurso;
                    cmd.Parameters.Add("@dataHora", SqlDbType.DateTime).Value = dataEHora;

                    // ID_ALUNO também é string/VARCHAR
                    cmd.Parameters.Add("@idAluno", SqlDbType.NVarChar, 50);

                    int aulasAgendadas = 0;
                    foreach (string idAluno in idsAlunos)
                    {
                        cmd.Parameters["@idAluno"].Value = idAluno;
                        cmd.ExecuteNonQuery();
                        aulasAgendadas++;
                    }

                    transaction.Commit();
                    MessageBox.Show($"Sucesso! {aulasAgendadas} aulas agendadas para o dia {dataEHora:dd/MM/yyyy} às {dataEHora:HH:mm}.", "Agendamento Concluído");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Erro ao salvar agendamento: " + ex.Message, "Erro Crítico");
                }
            }
        }
    }
}