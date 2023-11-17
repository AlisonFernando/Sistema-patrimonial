using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using model;

namespace UI
{
    public partial class CadColaborador : Form
    {
        private ColaboradorBLL colaboradorBLL = new ColaboradorBLL();
        private List<Colaborador> colaboradoresAtivos = new List<Colaborador>();
        private List<Colaborador> colaboradoresDesativados = new List<Colaborador>();
        Colaborador colaborador = new Colaborador();
        public CadColaborador(Colaborador colaborador)
        {
            InitializeComponent();

            if (colaborador != null)
            {
                txtID.Text = colaborador.ID_colaborador.ToString();
                InputColabNome.Text = colaborador.NomeColaborador;
                inputColabEmail.Text = colaborador.EmailColaborador;
                inputColabSenha.Text = colaborador.SenhaColaborador;
                inputColabTel.Text = colaborador.TelefoneColaborador.ToString();
                inputColabAgenda.Text = colaborador.AgendaColaborador.ToString();
                check_ativo.Enabled = false;
                inputColabSenha.Enabled = false;
            }
        }

        private void CadColaborador_Load(object sender, EventArgs e)
        {
            CarregarSetorComboBox();
            LoadColaboradores();
        }
        public void LoadColaboradores()
        {
            colaboradoresAtivos = colaboradorBLL.GetColaboradoresAtivos();
            MostrarColaboradores.DataSource = colaboradoresAtivos;
            colaboradoresDesativados = colaboradorBLL.GetColaboradoresDesativados();
            MostrarColaboradoresDesativados.DataSource = colaboradoresDesativados;
        }

        private void CarregarSetorComboBox()
        {
            SetorBLL setorBLL = new SetorBLL();
            DataTable dt = setorBLL.CarregarSetor();

            escolherSetor.DisplayMember = "Nome_Setor"; // Define a coluna a ser exibida
            escolherSetor.ValueMember = "ID_setor";    // Define a coluna a ser usada como valor selecionado
            escolherSetor.DataSource = dt;
        }

        private void btn_selectEquips_Click(object sender, EventArgs e)
        {


            Setor setor = new Setor();

            //Passa o texto dos campos digitados
            colaborador.NomeColaborador = InputColabNome.Text;
            colaborador.SenhaColaborador = inputColabSenha.Text;
            colaborador.AgendaColaborador = inputColabAgenda.Text;
            colaborador.TelefoneColaborador = inputColabTel.Text;
            colaborador.Ativo_inativo = check_ativo.Checked;
            colaborador.EmailColaborador = inputColabEmail.Text;
            colaborador.id_setor = escolherSetor.SelectedValue.ToString();


            //Recebe os campos já tratados para usar na tela SelectEquips
            DadosGlobais.NomeColaborador = colaborador.NomeColaborador;
            DadosGlobais.SenhaColaborador = colaborador.SenhaColaborador;
            DadosGlobais.AgendaColaborador = colaborador.AgendaColaborador;
            DadosGlobais.TelefoneColaborador = colaborador.TelefoneColaborador;
            DadosGlobais.Ativo_inativo = colaborador.Ativo_inativo;
            DadosGlobais.EmailColaborador = colaborador.EmailColaborador;
            DadosGlobais.id_setor = colaborador.id_setor;


            // Executa a verificação se caso o usuário não digitar nenhum valor nos campos
            if (colaborador.NomeColaborador.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique o nome do colaborador e tente novamente");
                return;
            }
            else if (colaborador.EmailColaborador.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique o email e tente novamente");
                return;
            }
            else if (colaborador.SenhaColaborador.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique a senha e tente novamento");
                return;
            }
            else if (colaborador.AgendaColaborador.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique a agenda e tente novamente");
                return;
            }
            else if (colaborador.TelefoneColaborador.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique o telefone e tente novamente");
                return;
            }

            //Verificar se o que foi digitado no campo de telefone são números
            string textoDigitado = inputColabTel.Text;

            textoDigitado = new string(textoDigitado.Where(char.IsDigit).ToArray());

            if (textoDigitado.Length == 11)
            {
                colaborador.TelefoneColaborador = textoDigitado;
            }
            else
            {
                MessageBox.Show("O número de telefone deve conter exatamente 11 dígitos.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputColabTel.Focus();
                return;
            }

            //Verifica se o que foi digitando no campo de email é realmente um email
            string email = inputColabEmail.Text;
            if (colaboradorBLL.IsValidEmail(email))
            {
                colaborador.EmailColaborador = email;
            }
            else
            {
                MessageBox.Show("Por favor, insira um endereço de e-mail válido.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inputColabEmail.Text = string.Empty;
                return;
            }


            string verificar = colaboradorBLL.VerificarNome(colaborador.NomeColaborador);
            if (verificar == "nome existente")
            {
                MessageBox.Show("Já possui no banco de dados");
                return;
            }
            UI.SelectEquips selectEquips = new UI.SelectEquips();
            selectEquips.ShowDialog();
        }

        public static class DadosGlobais
        {
            public static string NomeColaborador { get; set; }
            public static string SenhaColaborador { get; set; }
            public static string AgendaColaborador { get; set; }
            public static string TelefoneColaborador { get; set; }
            public static bool Ativo_inativo { get; set; }
            public static string EmailColaborador { get; set; }
            public static string id_setor { get; set; }
        }

        private void btnCancelarCad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputColabTel_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = new string(inputColabTel.Text.Where(char.IsDigit).ToArray());

            if (phoneNumber.Length == 11)
            {
                phoneNumber = string.Format("({0}) {1}-{2}",
                    phoneNumber.Substring(0, 2),
                    phoneNumber.Substring(2, 5),
                    phoneNumber.Substring(6, 4));
            }

            inputColabTel.Text = phoneNumber;
            inputColabTel.SelectionStart = inputColabTel.Text.Length;
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                int ID_Colab = int.Parse(txtID.Text);
                colaboradorBLL.DesativarColaborador(ID_Colab);
                MessageBox.Show("Colaborador desativado com sucesso.");
                InputColabNome.Text = string.Empty;
                inputColabEmail.Text = string.Empty;
                inputColabSenha.Enabled = true;
                inputColabTel.Text = string.Empty;
                inputColabAgenda.Text = string.Empty;
                txtID.Text = string.Empty;
                check_ativo.Enabled = true;
                LoadColaboradores();
            }
            else
            {
                MessageBox.Show("Escolha um colaborador e tente novamente");
            }
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            InputColabNome.Text = string.Empty;
            inputColabEmail.Text = string.Empty;
            inputColabSenha.Enabled = true;
            inputColabTel.Text = string.Empty;
            inputColabAgenda.Text = string.Empty;
            txtID.Text = string.Empty;
            check_ativo.Enabled = true;
            LoadColaboradores();
        }

        private void escolherSetor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                int ID_Colab = int.Parse(txtID.Text);
                colaboradorBLL.AtivarColaborador(ID_Colab);
                MessageBox.Show("Colaborador ativado com sucesso.");
                InputColabNome.Text = string.Empty;
                inputColabEmail.Text = string.Empty;
                inputColabSenha.Enabled = true;
                inputColabTel.Text = string.Empty;
                inputColabAgenda.Text = string.Empty;
                txtID.Text = string.Empty;
                check_ativo.Enabled = true;
                LoadColaboradores();
            }
            else
            {
                MessageBox.Show("Escolha um colaborador e tente novamente");
            }
        }

        private void MostrarColaboradores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarColaboradores.Rows[e.RowIndex];

                int ID_colaborador = (int)selectedRow.Cells["id_colaborador"].Value;
                Colaborador colaborador = colaboradoresAtivos.Find(f => f.ID_colaborador == ID_colaborador);

                txtID.Text = colaborador.ID_colaborador.ToString();
                InputColabNome.Text = colaborador.NomeColaborador;
                inputColabEmail.Text = colaborador.EmailColaborador;
                inputColabTel.Text = colaborador.TelefoneColaborador;
                inputColabAgenda.Text = colaborador.AgendaColaborador;
                inputColabSenha.Enabled = false;
            }
        }

        private void MostrarColaboradoresDesativados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarColaboradoresDesativados.Rows[e.RowIndex];

                int ID_colaborador = (int)selectedRow.Cells["ID_ColabDesativado"].Value;
                Colaborador colaborador = colaboradoresDesativados.Find(f => f.ID_colaborador == ID_colaborador);

                txtID.Text = colaborador.ID_colaborador.ToString();
                InputColabNome.Text = colaborador.NomeColaborador;
                inputColabEmail.Text = colaborador.EmailColaborador;
                inputColabTel.Text = colaborador.TelefoneColaborador;
                inputColabAgenda.Text = colaborador.AgendaColaborador;
                inputColabSenha.Enabled = false;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomePesquisado = InputColabNome.Text.Trim();

            List<Colaborador> colaboradoresFiltrados = colaboradoresAtivos
                .Concat(colaboradoresDesativados)
                .Where(colaborador =>
                    colaborador.NomeColaborador.Contains(nomePesquisado, StringComparison.OrdinalIgnoreCase) ||
                    colaborador.EmailColaborador.Contains(nomePesquisado, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (colaboradoresFiltrados.Count == 0)
            {
                MessageBox.Show("Colaborador não encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nomePesquisado == string.Empty)
            {
                MessageBox.Show("Digite o nome do colaborador ou e-mail e tente novamente");
                InputColabNome.Focus();
            }
            else
            {
                MostrarColaboradores.DataSource = colaboradoresFiltrados;
                MostrarColaboradoresDesativados.DataSource = colaboradoresFiltrados;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}