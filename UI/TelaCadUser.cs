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

        public TelaCadUser(Usuario usuario)
        {
            InitializeComponent();
            if (usuario != null)
            {
                txtID.Text = usuario.id_usuario.ToString();
                inputUserNome.Text = usuario.nome;
                inputUserEmail.Text = usuario.email.ToString();
                inputUserSenha.Enabled = false;
                txtConfirEmail.Enabled = false;
                txtConfirSenha.Enabled = false;
            }
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

            // Verificação de espaços em branco em nome e email
            if (string.IsNullOrWhiteSpace(usuario.Nome) || string.IsNullOrWhiteSpace(usuario.Email))
            {
                MessageBox.Show("Nome e email devem ser preenchidos.");
                return;
            }

            // Verificação de espaços em branco em nome e email
            if (usuario.Nome.Contains(" ") || usuario.Email.Contains(" "))
            {
                MessageBox.Show("Nome e email não podem conter espaços em branco.");
                return;
            }

            // Verificação do email
            if (!UserBLL.IsValidEmail(usuario.Email))
            {
                MessageBox.Show("E-mail inválido.");
                return;
            }

            // Verificação se o email já existe no banco de dados (apenas durante inserção)
            if (string.IsNullOrEmpty(txtID.Text))
            {
                UserBLL verificarEmailBLL = new UserBLL();
                string verificar = verificarEmailBLL.VerificarEmail(usuario.Email);

                if (verificar == "Email existente")
                {
                    MessageBox.Show("O email já existe no banco de dados");
                    return;
                }
            }

            // Verificação se é uma atualização de nome ou e-mail (ignorando senha e confirmações)
            bool atualizacaoNomeOuEmail = !string.IsNullOrEmpty(txtID.Text) && (inputUserNome.Text != usuarios.Find(u => u.id_usuario == usuario.id_usuario)?.Nome || inputUserEmail.Text != usuarios.Find(u => u.id_usuario == usuario.id_usuario)?.Email);

            if (!atualizacaoNomeOuEmail)
            {
                // Verificação da senha (opcional durante atualização)
                if (string.IsNullOrWhiteSpace(usuario.Senha))
                {
                    MessageBox.Show("Verifique a senha e tente novamente");
                    inputUserSenha.Focus();
                    return;
                }

                // Verificação de espaços em branco na senha
                if (!string.IsNullOrEmpty(usuario.Senha) && usuario.Senha.Contains(" "))
                {
                    MessageBox.Show("A senha não pode conter espaços em branco.");
                    return;
                }

                // Verificação do campo Confirmar Email (opcional durante atualização)
                if (string.IsNullOrWhiteSpace(usuario.ConfirmarEmail))
                {
                    MessageBox.Show("Digite a confirmação de email e tente novamente");
                    txtConfirEmail.Focus();
                    return;
                }

                if (usuario.ConfirmarEmail != usuario.Email)
                {
                    MessageBox.Show("E-mail de confirmação diferente do email principal.");
                    return;
                }

                // Verificação do campo Confirmar Senha (opcional durante atualização)
                if (string.IsNullOrWhiteSpace(usuario.ConfirmarSenha))
                {
                    MessageBox.Show("Digite a confirmação de senha e tente novamente");
                    txtConfirSenha.Focus();
                    return;
                }

                if (usuario.ConfirmarSenha != usuario.Senha)
                {
                    MessageBox.Show("Senha de confirmação diferente da senha principal.");
                    return;
                }
            }

            // Realiza o cadastro ou atualização do usuário
            string retorno;

            UserBLL cadUserBLL = new UserBLL();
            if (!string.IsNullOrEmpty(txtID.Text))
                retorno = cadUserBLL.UpdateUsuario(usuario);
            else
                retorno = cadUserBLL.CadUser(usuario);

            if (retorno == "Sucesso")
            {
                MessageBox.Show("Ação efetuada com sucesso!");
            }

            LoadUsuarios();
            btn_limpar.PerformClick();
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
