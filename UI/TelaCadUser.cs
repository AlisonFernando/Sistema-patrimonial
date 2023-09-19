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
using MySqlX.XDevAPI.Relational;

namespace UI
{
    public partial class TelaCadUser : Form
    {
        private UserBLL userBLL = new UserBLL();
        private List<Usuario> usuarios = new List<Usuario>();

        public TelaCadUser()
        {
            InitializeComponent();
        }
        public void LoadUsuarios()
        {
            usuarios = userBLL.GetUsuarios();
            MostrarUsuarios.DataSource = usuarios;
        }

        private void btnCadUserSucesso_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            if (!string.IsNullOrEmpty(txtID.Text))
                usuario.id_usuario = int.Parse(txtID.Text);
            usuario.Nome = inputUserNome.Text;
            usuario.Email = inputUserEmail.Text;
            usuario.Senha = inputUserSenha.Text;
            usuario.ConfirmarEmail = txtConfirEmail.Text;
            usuario.ConfirmarSenha = txtConfirSenha.Text;

            // Executa a verificação se caso o usuário não digitar nenhum valor nos campos
            if (string.IsNullOrWhiteSpace(usuario.Nome))
            {
                MessageBox.Show("Verifique seu nome e tente novamente");
                inputUserNome.Focus();
            }
            else if (string.IsNullOrWhiteSpace(usuario.Email))
            {
                MessageBox.Show("Verifique o e-mail e tente novamente");
                inputUserEmail.Focus();
            }
            else if (string.IsNullOrWhiteSpace(usuario.Senha))
            {
                MessageBox.Show("Verifique a senha e tente novamente");
                inputUserSenha.Focus();
            }

            //Verifica se os campos de confirmação batem com o digitado
            else if (txtConfirEmail.Enabled != false)
            {
                if (usuario.ConfirmarEmail != usuario.Email)
                {
                    MessageBox.Show("E-mail errado ou não preenchido no campo, verifique e tente novamente");
                    return;
                }
            }
            else if (txtConfirSenha.Enabled != false)
            {
                if (usuario.ConfirmarSenha != usuario.Senha)
                {
                    MessageBox.Show("Senha digitada está incorreta ou não foi preenchido o campo, tente novamente");
                    return;
                }
            }

            string verificar;

            // Verifica se o e-mail digitado já existe no banco de dados
            string email = inputUserEmail.Text;

            if (UserBLL.IsValidEmail(email))
            {
                MessageBox.Show("E-mail válido.");
            }
            else
            {
                MessageBox.Show("E-mail inválido.");
                return;
            }
            if (string.IsNullOrEmpty(txtID.Text))
            {
                UserBLL verificarEmailBLL = new UserBLL();
                verificar = verificarEmailBLL.VerificarEmail(usuario.Email);
            }
            else
                verificar = "Email não existe";

            if (verificar == "Email existente")
            {
                MessageBox.Show("O email já existe no banco de dados");
                return;
            }
            else if (verificar == "Email não existe")
            {

                // Realiza o cadastro do usuário
                string retorno;

                UserBLL cadUserBLL = new UserBLL();
                if (!string.IsNullOrEmpty(txtID.Text))
                    retorno = cadUserBLL.UpdateUsuario(usuario);
                else
                    retorno = cadUserBLL.CadUser(usuario);

                if (retorno == "Sucesso")
                {
                    MessageBox.Show("Cadastro efetuado");

                }
            }

            btn_limpar.PerformClick();
            LoadUsuarios();
            txtConfirEmail.Enabled = true;
            txtConfirSenha.Enabled = true;
            inputUserSenha.Enabled = true;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            inputUserNome.Text = string.Empty;
            inputUserEmail.Text = string.Empty;
            inputUserSenha.Text = string.Empty;
            txtConfirEmail.Text = string.Empty;
            txtConfirSenha.Text = string.Empty;
            txtConfirEmail.Enabled = true;
            txtConfirSenha.Enabled = true;
            inputUserSenha.Enabled = true;

        }

        private void btnCancelarCadUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TelaCadUser_Load(object sender, EventArgs e)
        {
            LoadUsuarios();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                int id_usuario = int.Parse(txtID.Text);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este usuário?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    userBLL.DeleteUsuario(id_usuario);
                    LoadUsuarios();
                }


                MessageBox.Show("Usuário deletado com sucesso!");
                btn_limpar.PerformClick();
            }
        }

        private void MostrarUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MostrarUsuarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarUsuarios.Rows[e.RowIndex];

                int id_usuario = (int)selectedRow.Cells["Id"].Value;
                Usuario usuario = usuarios.Find(u => u.id_usuario == id_usuario);

                txtID.Text = usuario.id_usuario.ToString();
                inputUserNome.Text = usuario.Nome;
                inputUserEmail.Text = usuario.email;
                txtConfirEmail.Enabled = false;
                txtConfirSenha.Enabled = false;
                inputUserSenha.Enabled = false;


                /*
                                Usuario usuario = usuarios.Find(u => u.id_usuario == id_usuario);
                                if (usuario != null)
                                {
                                    DataGridViewTextBoxCell cellNome = selectedRow.Cells["Nome"] as DataGridViewTextBoxCell;
                                    DataGridViewTextBoxCell cellEmail = selectedRow.Cells["Email"] as DataGridViewTextBoxCell;

                                    cellNome.ReadOnly = false;
                                    cellEmail.ReadOnly = false;*/

            }

            //MessageBox.Show("Usuário alterado com sucesso!");
        }
    }
}
