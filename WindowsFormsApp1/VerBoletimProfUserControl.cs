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
using static ProjetoProg.Btn; // Assumindo que Btn é o namespace correto

namespace WindowsFormsApp1
{
    public partial class VerBoletimProfUserControl : UserControl
    {
       
        public VerBoletimProfUserControl()
        {
            InitializeComponent();

            // Adiciona o manipulador de eventos para o ComboBox, garantindo que a função CarregarBoletim 
            // seja chamada assim que um aluno for selecionado.
            if (CmbAluno != null)
            {
                // Verifica se o evento já foi adicionado para evitar duplicação
                CmbAluno.SelectedIndexChanged -= CmbAluno_SelectedIndexChanged;
                CmbAluno.SelectedIndexChanged += CmbAluno_SelectedIndexChanged;
            }
        }

        private void VerBoletimProfUserControl_Load(object sender, EventArgs e)
        {
            // Verifica se o ComboBox foi encontrado antes de tentar carregar os dados
            if (CmbAluno != null)
            {
                CarregarAlunos();
            }
            else
            {
                // Se o componente não for encontrado, exibe um erro
                MessageBox.Show("Erro de componente: O ComboBox 'CmbAluno' não foi encontrado no User Control.", "Erro de Configuração");
            }
        }

        private void CarregarAlunos()
        {
            // 1. VERIFICAÇÃO CRÍTICA: Garantir que o ID do usuário não seja nulo/vazio
            string idProfessor = SessaoUsuario.IdUsuario;

            if (string.IsNullOrEmpty(idProfessor))
            {
                MessageBox.Show("Erro de Sessão: ID do professor não encontrado. Faça login novamente.", "Erro de Autorização");
                if (CmbAluno != null) CmbAluno.DataSource = null; // Limpa o ComboBox
                return; // Sai da função
            }

            string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // QUERY ORIGINAL CORRIGIDA: Usa DISTINCT para garantir que cada aluno (ID e Nome) 
                    // apareça apenas uma vez, mesmo que compartilhem múltiplos cursos.
                    string query = @"
                        SELECT DISTINCT
                            A.ID_ALUNO, 
                            A.NOME_ALUNO
                        FROM ALUNOS A
                        INNER JOIN ALUNOS_CURSOS AC ON A.ID_ALUNO = AC.ID_ALUNO
                        INNER JOIN CURSOS_PROFESSORES CP ON AC.ID_CURSO = CP.ID_CURSO -- LIGA ALUNO com PROFESSOR através do CURSO em comum
                        WHERE CP.ID_PROFESSOR = @idProfessor
                        ORDER BY A.NOME_ALUNO";


                    SqlCommand cmd = new SqlCommand(query, con);
                    // O parâmetro do ID do Professor é usado para filtrar os alunos
                    cmd.Parameters.Add("@idProfessor", SqlDbType.NVarChar, 50).Value = idProfessor;

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // Se a consulta retornar dados, carrega no ComboBox
                    if (dt.Rows.Count > 0)
                    {
                        if (CmbAluno != null)
                        {
                            // A chave (ValueMember) deve ser o ID do aluno
                            CmbAluno.ValueMember = "ID_ALUNO";
                            // O que é exibido para o usuário (DisplayMember) é o nome
                            CmbAluno.DisplayMember = "NOME_ALUNO";
                            CmbAluno.DataSource = dt;

                            // Define o índice -1 para evitar que selecione automaticamente o primeiro item
                            CmbAluno.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum aluno associado aos seus cursos foi encontrado.", "Informação");
                        if (CmbAluno != null) CmbAluno.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar alunos: " + ex.Message, "Erro de Banco de Dados");
                }
            }
        }

        // Novo método para carregar o boletim do aluno selecionado no DataGridView
        private void CarregarBoletim(string idAluno)
        {
            if (DgvBoletim == null)
            {
                MessageBox.Show("Erro de componente: O DataGridView 'DgvBoletim' não foi encontrado.", "Erro de Configuração");
                return;
            }

            string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027317PR2;User ID=aluno;Password=aluno";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Consulta que seleciona as notas da tabela NOTAS, calcula a média e determina o status.
                    // A média é calculada como (N1+N2+N3+N4)/4.0. Status é APROVADO se >= 6.5.
                    string queryBoletim = @"
                        SELECT
                            C.NOME_CURSO AS Disciplina,
                            N.NOTA_1,
                            N.NOTA_2,
                            N.NOTA_3,
                            N.NOTA_4,
                            -- Calcula a média, tratando as notas como DECIMAL para garantir precisão
                            (N.NOTA_1 + N.NOTA_2 + N.NOTA_3 + N.NOTA_4) / 4.0 AS Media,
                            -- Define o status: APROVADO se Média >= 6.5, REPROVADO caso contrário
                            CASE
                                WHEN (N.NOTA_1 + N.NOTA_2 + N.NOTA_3 + N.NOTA_4) / 4.0 >= 6.5 THEN 'APROVADO'
                                ELSE 'REPROVADO'
                            END AS Status
                        FROM boletins N
                        INNER JOIN CURSOS C ON N.ID_CURSO = C.ID_CURSO
                        WHERE N.ID_ALUNO = @idAluno";


                    SqlCommand cmd = new SqlCommand(queryBoletim, con);
                    // Adicionamos o ID do aluno como parâmetro para evitar SQL Injection
                    cmd.Parameters.Add("@idAluno", SqlDbType.NVarChar, 50).Value = idAluno;

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dtBoletim = new DataTable();
                    dtBoletim.Load(reader);

                    // Carrega os dados no DataGridView
                    DgvBoletim.DataSource = dtBoletim;

                    // Opcional: Ajusta a formatação da coluna de Média para exibir apenas uma casa decimal
                    if (DgvBoletim.Columns.Contains("Media"))
                    {
                        DgvBoletim.Columns["Media"].DefaultCellStyle.Format = "N1";
                    }

                    if (dtBoletim.Rows.Count == 0)
                    {
                        // Limpa o DataGridView se não houver notas para o aluno selecionado
                        DgvBoletim.DataSource = null;
                        // Opcional: MessageBox.Show($"Nenhuma nota encontrada para o aluno com ID {idAluno}.", "Informação");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar o boletim: " + ex.Message, "Erro de Banco de Dados");
                }
            }
        }

        // Este método é chamado sempre que um novo aluno é selecionado no ComboBox
        private void CmbAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Certifica-se de que há um valor selecionado e que este valor não é a linha de cabeçalho
            if (CmbAluno != null && CmbAluno.SelectedIndex != -1 && CmbAluno.SelectedValue != null)
            {
                // Obtém o ID do aluno selecionado (armazenado no ValueMember="ID_ALUNO")
                string idAlunoSelecionado = CmbAluno.SelectedValue.ToString();

                // Chama o novo método para carregar o boletim
                CarregarBoletim(idAlunoSelecionado);
            }
            else if (DgvBoletim != null)
            {
                // Limpa o DataGridView se nada estiver selecionado
                DgvBoletim.DataSource = null;
            }
        }
    }
}