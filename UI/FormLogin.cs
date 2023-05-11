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
            
            Login modelLogin = new Login();
            modelLogin.Email = input_email.Text;
            modelLogin.Password = input_senha.Text;

            if("teste@teste.com" == modelLogin.Email & "teste" == modelLogin.Password)
            {
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                MessageBox.Show("Você esta logado!");
                telaPrincipal.Show();
                this.Dispose(false);
            }
            else
            {
                MessageBox.Show("E-mail ou senha incorretos, tente novamente");
            }

            //LoginBLL loginBLL = new LoginBLL();
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
