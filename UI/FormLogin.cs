using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using model;

namespace UI
{
    public partial class FormLogin : Form
    {
        public UserBLL userBLL = new UserBLL();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = input_email.Text;
            string senha = input_senha.Text;

            if (email.Trim().Length <= 0)
            {
                MessageBox.Show("Digite um email e tente novamente");
                return;
            }
            else if (senha.Trim().Length <= 0)
            {
                MessageBox.Show("Digite uma senha válida e tente novamente");
                return;
            }

            if (userBLL.VerificarCredenciais(email, senha))
            {
                MessageBox.Show("Login bem-sucedido!");
                this.Hide();

                TelaPrincipal telaPrincipal = new TelaPrincipal();
                telaPrincipal.Closed += (s, args) => this.Close(); // Fecha o aplicativo quando a tela principal for fechada
                telaPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }
        }

        private void btnEsqueciSenha_Click(object sender, EventArgs e)
        {
            this.Hide();
            UI.TelaEsqueciSenha telaEsqueciSenha = new UI.TelaEsqueciSenha();
            telaEsqueciSenha.ShowDialog();
        }
    }
}
