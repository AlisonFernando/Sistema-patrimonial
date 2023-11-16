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
using Microsoft.VisualBasic.ApplicationServices;
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

            if (string.IsNullOrWhiteSpace(email) || email.Contains(" ") || email.Any(char.IsUpper))
            {
                MessageBox.Show("Digite um email válido e tente novamente.");
                return;
            }

            if (string.IsNullOrWhiteSpace(senha) || senha.Contains(" "))
            {
                MessageBox.Show("Digite uma senha válida e tente novamente.");
                return;
            }

            if (userBLL.VerificarCredenciais(email, senha))
            {
                int userChamado = userBLL.ObterUserChamado(email);

                // Atribua o valor à variável global.
                Program.UserChamado = userChamado;
                Program.UserEmail = email;

                // Abra a TelaPrincipal.
                MessageBox.Show("Login bem-sucedido!");
                this.Hide();

                TelaPrincipal telaPrincipal = new TelaPrincipal(userChamado, email);
                telaPrincipal.Closed += (s, args) => this.Close(); // Fecha o aplicativo quando a tela principal for fechada
                telaPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Este e-mail pertence a um usuário desativado ou as credenciais são incorretas. Use um e-mail válido.");
            }
        }
    }
}
