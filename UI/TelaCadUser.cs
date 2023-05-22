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

            //Executa a verificação de cadastro de usuario
            if (usuario.Nome == "alison")
            {
                MessageBox.Show("ou");
            }
            else
            {
                MessageBox.Show("Dados incorretos, tente novamente!");
            }
        }

        private void TelaCadUser_Load(object sender, EventArgs e)
        {

        }
    }
}
