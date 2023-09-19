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

        public CadColaborador()
        {
            InitializeComponent();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
        }

        private void CadColaborador_Load(object sender, EventArgs e)
        {
            CarregarSetorComboBox();
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
            ColaboradorBLL colaboradorBLL = new ColaboradorBLL();
            Colaborador colaborador = new Colaborador();
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
    }
}