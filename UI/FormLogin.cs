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
using model;

namespace UI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Email = input_email.Text;
            login.Senha = input_senha.Text;

            //Valida se tem espaço em branco nos inputs

            if (login.Email.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique o e-mail e tente novamente");
                return;
            }
            else if (login.Senha.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique a senha e tente novamente");
                return;
            }

            //Validação se os dados estão corretos
            LoginBLL validarCampos = new LoginBLL();

            string ValidarEmail = validarCampos.ValidarEmail(login.Email);
            string ValidarSenha = validarCampos.ValidarSenha(login.Senha);

            //Valida se o e-mail digitado está correto
            if (ValidarEmail == "Email correto" && ValidarSenha == "Senha correta")
            {
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                MessageBox.Show("Você esta logado!");
                telaPrincipal.Show();
                this.Dispose(false);
            }
            else if (ValidarEmail == "Email incorreto" || ValidarSenha == "Senha incorreta")
            {
                MessageBox.Show("E-mail ou senha incorretos!");
                return;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadUser_Click(object sender, EventArgs e)
        {
            UI.TelaCadUser telaCadUser = new UI.TelaCadUser();
            telaCadUser.ShowDialog();
        }

        private void btnEsqueciSenha_Click(object sender, EventArgs e)
        {
            UI.TelaEsqueciSenha telaEsqueciSenha = new UI.TelaEsqueciSenha();
            telaEsqueciSenha.ShowDialog();
        }
    }
}
