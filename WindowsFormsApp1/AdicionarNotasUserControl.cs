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
    public partial class AdicionarNotasUserControl : UserControl
    {

        // Conexão de Banco de Dados (substitua a string de conexão pela sua, se necessário)
        private const string ConnectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";

        public AdicionarNotasUserControl()
        {
            InitializeComponent();
        }

        private void AdicionaNotasUserControl_Load(object sender, EventArgs e)
        {
            // 1. Configura o DomainUpDown (DomNota)
            ConfigurarDomainUpDown();

            // 2. Carrega os alunos (primeiro passo)
            CarregarAlunos();

            // 3. Liga os eventos
            LigarEventos();
        }

        private void ConfigurarDomainUpDown()
        {
            if (DomNota != null)
            {
                DomNota.Items.Clear();
                // Gera notas de 0.0 até 10.0, de 0.5 em 0.5
                for (double nota = 0.0; nota <= 10.0; nota += 0.5)
                {
                    // Adiciona a nota formatada (ex: "7.5", "10.0")
                    DomNota.Items.Add(nota.ToString("N1"));
                }
                DomNota.SelectedIndex = 0; // Começa em 0.0
                DomNota.Wrap = false; // Não volta ao início ao chegar no fim
            }

            if (CmbNotas != null)
            {
                CmbNotas.Items.Clear();
                // Adiciona as opções de notas disponíveis na tabela NOTAS
                CmbNotas.Items.Add("NOTA_1");
                CmbNotas.Items.Add("NOTA_2");
                CmbNotas.Items.Add("NOTA_3");
                CmbNotas.Items.Add("NOTA_4");
                CmbNotas.SelectedIndex = -1; // Sem seleção inicial
            }
        }

        private void LigarEventos()
        {
            // Liga os manipuladores de eventos
            if (CmbAlunoNotas != null)
            {
                CmbAlunoNotas.SelectedIndexChanged -= CmbAlunoNotas_SelectedIndexChanged;
                CmbAlunoNotas.SelectedIndexChanged += CmbAlunoNotas_SelectedIndexChanged;
            }

            if (CmbDisciplina != null)
            {
                CmbDisciplina.SelectedIndexChanged -= CmbDisciplina_SelectedIndexChanged;
                CmbDisciplina.SelectedIndexChanged += CmbDisciplina_SelectedIndexChanged;
            }

            if (BtnSalvarNotas != null)
            {
                BtnSalvarNotas.Click -= BtnSalvarNotas_Click;
                BtnSalvarNotas.Click += BtnSalvarNotas_Click;
            }
        }

        // =========================================================================
        // PASSO 1: Carregar Alunos (ComboBox CmbAlunoNotas)
        // =========================================================================

        private void CarregarAlunos()
        {
            string idProfessor = SessaoUsuario.IdUsuario;

            if (string.IsNullOrEmpty(idProfessor))
            {
                MessageBox.Show("Erro de Sessão: ID do professor não encontrado.", "Erro de Autorização");
                if (CmbAlunoNotas != null) CmbAlunoNotas.DataSource = null;
                return;
            }

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    string query = @"
                        SELECT DISTINCT
                            A.ID_ALUNO, 
                            A.NOME_ALUNO
                        FROM ALUNOS A
                        INNER JOIN ALUNOS_CURSOS AC ON A.ID_ALUNO = AC.ID_ALUNO
                        INNER JOIN CURSOS_PROFESSORES CP ON AC.ID_CURSO = CP.ID_CURSO 
                        WHERE CP.ID_PROFESSOR = @idProfessor
                        ORDER BY A.NOME_ALUNO";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@idProfessor", SqlDbType.NVarChar, 50).Value = idProfessor;

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    if (CmbAlunoNotas != null)
                    {
                        CmbAlunoNotas.ValueMember = "ID_ALUNO";
                        CmbAlunoNotas.DisplayMember = "NOME_ALUNO";
                        CmbAlunoNotas.DataSource = dt;
                        CmbAlunoNotas.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar alunos: " + ex.Message, "Erro de Banco de Dados");
                }
            }
        }

        private void CmbAlunoNotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpa a disciplina e tenta carregar as disciplinas para o aluno selecionado
            if (CmbDisciplina != null) CmbDisciplina.DataSource = null;

            if (CmbAlunoNotas != null && CmbAlunoNotas.SelectedValue != null)
            {
                string idAluno = CmbAlunoNotas.SelectedValue.ToString();
                CarregarDisciplinas(idAluno);
            }
        }

        // =========================================================================
        // PASSO 2: Carregar Disciplinas (ComboBox CmbDisciplina)
        // =========================================================================

        private void CarregarDisciplinas(string idAluno)
        {
            string idProfessor = SessaoUsuario.IdUsuario;
            if (string.IsNullOrEmpty(idProfessor)) return; // Já verificamos no Load, mas é bom garantir

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    // Seleciona as disciplinas que o aluno está matriculado E o professor está lecionando
                    string query = @"
                        SELECT
                            C.ID_CURSO,
                            C.NOME_CURSO
                        FROM CURSOS C
                        INNER JOIN ALUNOS_CURSOS AC ON C.ID_CURSO = AC.ID_CURSO
                        INNER JOIN CURSOS_PROFESSORES CP ON C.ID_CURSO = CP.ID_CURSO
                        WHERE AC.ID_ALUNO = @idAluno AND CP.ID_PROFESSOR = @idProfessor
                        ORDER BY C.NOME_CURSO";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add("@idAluno", SqlDbType.NVarChar, 50).Value = idAluno;
                    cmd.Parameters.Add("@idProfessor", SqlDbType.NVarChar, 50).Value = idProfessor;

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    if (CmbDisciplina != null)
                    {
                        CmbDisciplina.ValueMember = "ID_CURSO";
                        CmbDisciplina.DisplayMember = "NOME_CURSO";
                        CmbDisciplina.DataSource = dt;
                        CmbDisciplina.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar disciplinas: " + ex.Message, "Erro de Banco de Dados");
                }
            }
        }

        private void CmbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Quando a disciplina é selecionada, podemos, opcionalmente, pré-selecionar a nota 1
            if (CmbNotas != null)
            {
                CmbNotas.SelectedIndex = 0; // Seleciona NOTA_1 por padrão
            }
        }

        // =========================================================================
        // PASSO 3: Salvar a Nota (Botão BtnSalvarNotas)
        // =========================================================================

        private void BtnSalvarNotas_Click(object sender, EventArgs e)
        {
            if (CmbAlunoNotas?.SelectedValue == null || CmbDisciplina?.SelectedValue == null || CmbNotas?.SelectedItem == null || string.IsNullOrWhiteSpace(DomNota?.Text))
            {
                MessageBox.Show("Por favor, selecione o aluno, a disciplina, a nota (N1, N2, etc.) e o valor da nota.", "Campos Faltando");
                return;
            }

            string idAluno = CmbAlunoNotas.SelectedValue.ToString();
            string idCurso = CmbDisciplina.SelectedValue.ToString();
            string nomeColunaNota = CmbNotas.SelectedItem.ToString(); // Ex: NOTA_1

            // Tenta converter o valor do DomainUpDown para decimal
            if (!decimal.TryParse(DomNota.Text, out decimal valorNota))
            {
                MessageBox.Show("Valor da nota inválido. Use o formato com vírgula (Ex: 7,5).", "Erro de Formato");
                return;
            }

            SalvarNotaNoBanco(idAluno, idCurso, nomeColunaNota, valorNota);
        }

        private void SalvarNotaNoBanco(string idAluno, string idCurso, string nomeColunaNota, decimal valorNota)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();

                    // Query de INSERT OR UPDATE (UPSERT):
                    // 1. Tenta atualizar a nota existente (SET)
                    // 2. Se a linha não existir (WHERE), insere uma nova linha (INSERT).
                    // SQL Server (T-SQL) não tem um comando nativo 'UPSERT' simples, então usamos um MERGE ou o padrão abaixo:

                    // Passo 1: Tenta ATUALIZAR a nota específica
                    string updateQuery = $@"
                        UPDATE boletins
                        SET {nomeColunaNota} = @valorNota
                        WHERE ID_ALUNO = @idAluno AND ID_CURSO = @idCurso";

                    SqlCommand cmdUpdate = new SqlCommand(updateQuery, con);
                    cmdUpdate.Parameters.Add("@valorNota", SqlDbType.Decimal).Value = valorNota;
                    cmdUpdate.Parameters.Add("@idAluno", SqlDbType.NVarChar, 50).Value = idAluno;
                    cmdUpdate.Parameters.Add("@idCurso", SqlDbType.NVarChar, 50).Value = idCurso;

                    int linhasAfetadas = cmdUpdate.ExecuteNonQuery();

                    if (linhasAfetadas == 0)
                    {
                        // Passo 2: Se não houver linha para atualizar (ou seja, o aluno/curso não tem notas ainda), faz um INSERT
                        string insertQuery = $@"
                            INSERT INTO boletins (ID_ALUNO, ID_CURSO, {nomeColunaNota})
                            VALUES (@idAluno, @idCurso, @valorNota)";

                        SqlCommand cmdInsert = new SqlCommand(insertQuery, con);
                        cmdInsert.Parameters.Add("@idAluno", SqlDbType.NVarChar, 50).Value = idAluno;
                        cmdInsert.Parameters.Add("@idCurso", SqlDbType.NVarChar, 50).Value = idCurso;
                        cmdInsert.Parameters.Add("@valorNota", SqlDbType.Decimal).Value = valorNota;
                        // Adicionamos o valorNota também no insert (embora não seja uma boa prática, é necessário aqui)

                        cmdInsert.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Nota '{nomeColunaNota}' salva com sucesso para o aluno!", "Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar a nota: " + ex.Message, "Erro de Banco de Dados");
                }
            }
        }

        private void AdicionarNotasUserControl_Load(object sender, EventArgs e)
        {
            ConfigurarDomainUpDown();

            // 2. Carrega os alunos (primeiro passo)
            CarregarAlunos();

            // 3. Liga os eventos
            LigarEventos();
        }
    }
}
