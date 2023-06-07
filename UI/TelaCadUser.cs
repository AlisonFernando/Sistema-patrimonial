using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;
using BLL;
using DAL;

namespace UI
{
    public partial class TelaCadUser : Form
    {

        public TelaCadUser()
        {
            InitializeComponent();
        }

        private void btnCadUserSucesso_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.Nome = inputUserNome.Text;
            usuario.Email = inputUserEmail.Text;
            usuario.Senha = inputUserSenha.Text;

            // Executa a verificação se caso o usuário não digitar nenhum valor nos campos
            if (usuario.Nome.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique seu nome e tente novamente");
                return;
            }
            else if (usuario.Email.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique o e-mail e tente novamente");
                return;
            }
            else if (usuario.Senha.Trim().Length <= 0)
            {
                MessageBox.Show("Verifique a senha e tente novamente");
                return;
            }

            // Verifica se o e-mail digitado já existe no banco de dados
            UserBLL verificarEmailBLL = new UserBLL();
            string verificar = verificarEmailBLL.VerificarEmail(usuario.Email);

            if (verificar == "Email existente")
            {
                MessageBox.Show("O email já existe no banco de dados");
                return;
            }
            else if(verificar == "Email não existe"){

                // Realiza o cadastro do usuário
                UserBLL cadUserBLL = new UserBLL();
                string retorno = cadUserBLL.CadUser(usuario);

                if (retorno == "Sucesso")
                {
                    MessageBox.Show("Cadastro efetuado");

                }
            }
        }

            
    }
}
