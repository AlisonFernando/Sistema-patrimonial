﻿using MySql.Data.MySqlClient;
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
        private List<Usuario> usuariosDesativados = new List<Usuario>();
        private Usuario usuarioLogado;
        private string emailAtual;

        public TelaCadUser(Usuario usuario)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            if (usuario != null)
            {
                txtID.Text = usuario.id_usuario.ToString();
                inputUserNome.Text = usuario.nome;
                inputUserEmail.Text = usuario.email.ToString();
                checkAtivo.Checked = usuario.Ativo_inativo;

                inputUserSenha.Enabled = false;
                txtConfirEmail.Enabled = false;
                txtConfirSenha.Enabled = false;
                emailAtual = usuario.email;

            }
        }
        public void LoadUsuarios()
        {
            usuarios = userBLL.GetUsuariosAtivos();
            MostrarUsuarios.DataSource = usuarios;
            usuariosDesativados = userBLL.GetUsuariosDesativados();
            MostrarUsuariosDesativados.DataSource = usuariosDesativados;
        }
        private void TelaCadUser_Load(object sender, EventArgs e)
        {
            LoadUsuarios();
            CarregarPerfisDeAcesso();
        }


        Dictionary<string, int> niveisAcesso = new Dictionary<string, int>
        {
            { "ADM", 1 },
            { "TI", 2 }
        };
        private void CarregarPerfisDeAcesso()
        {
            ComboBoxAcesso.DataSource = new BindingSource(niveisAcesso, null);
            ComboBoxAcesso.DisplayMember = "Key";
            ComboBoxAcesso.ValueMember = "Value";
        }
        private void btnCadUserSucesso_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            if (!string.IsNullOrEmpty(txtID.Text))
                usuario.id_usuario = int.Parse(txtID.Text);

            usuario.Nome = inputUserNome.Text.Trim();
            usuario.Email = inputUserEmail.Text.Trim();
            usuario.Senha = inputUserSenha.Text;
            usuario.ConfirmarEmail = txtConfirEmail.Text.Trim();
            usuario.ConfirmarSenha = txtConfirSenha.Text;
            usuario.UserAcesso = (int)ComboBoxAcesso.SelectedValue;
            usuario.Ativo_inativo = checkAtivo.Checked;

            // Verificação de espaços em branco em nome
            if (string.IsNullOrWhiteSpace(usuario.Nome))
            {
                MessageBox.Show("Nome deve ser preenchido.");
                return;
            }

            // Verificação de espaços em branco em email
            if (usuario.Email.Contains(" "))
            {
                MessageBox.Show("Email não pode conter espaços em branco.");
                return;
            }

            // Verificação do email
            if (!UserBLL.IsValidEmail(usuario.Email))
            {
                MessageBox.Show("E-mail inválido.");
                return;
            }

            if (!checkAtivo.Checked)
            {
                MessageBox.Show("É necessário selecionar a opção Ativo para cadastrar/editar o usuario.");
                return;
            }

            string retorno;
            UserBLL cadUserBLL = new UserBLL();

            if (!string.IsNullOrEmpty(txtID.Text))
            {
                // Verifique se há uma atualização de nome ou e-mail (ignorando senha e confirmações)
                bool atualizacaoNomeOuEmail =
                    inputUserNome.Text != (usuarios.Find(u => u.id_usuario == usuario.id_usuario)?.Nome ?? "") ||
                    inputUserEmail.Text != (usuarios.Find(u => u.id_usuario == usuario.id_usuario)?.Email ?? "");

                if (atualizacaoNomeOuEmail)
                {
                    // Verifique se o novo e-mail já existe no banco de dados, apenas se o e-mail for alterado
                    if (inputUserEmail.Text != (usuarios.Find(u => u.id_usuario == usuario.id_usuario)?.Email ?? ""))
                    {
                        UserBLL verificarEmailBLL = new UserBLL();
                        string verificar = verificarEmailBLL.VerificarEmail(usuario.Email);

                        if (verificar == "Email existente")
                        {
                            MessageBox.Show("O email já existe no banco de dados");
                            return;
                        }
                    }
                }

                retorno = cadUserBLL.UpdateUsuario(usuario, Program.UserEmail);
            }
            else
            {
                // Se for uma inserção, verifique se o e-mail já existe no banco de dados
                UserBLL verificarEmailBLL = new UserBLL();
                string verificar = verificarEmailBLL.VerificarEmail(usuario.Email);

                if (verificar == "Email existente")
                {
                    MessageBox.Show("O email já existe no banco de dados");
                    return;
                }

                retorno = cadUserBLL.CadUser(usuario, Program.UserEmail);
            }

            if (retorno == "Sucesso")
            {
                MessageBox.Show("Ação efetuada com sucesso!");
                LoadUsuarios();
                btn_limpar.PerformClick();
                txtConfirEmail.Enabled = true;
                txtConfirSenha.Enabled = true;
                inputUserSenha.Enabled = true;
                checkAtivo.Checked = false;
            }
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
            checkAtivo.Checked = false;
        }

        private void btnCancelarCadUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnVerUser_Click(object sender, EventArgs e)
        {
            this.Close();
            UI.VerUser telaveruser = new UI.VerUser();
            telaveruser.ShowDialog();
        }
        private void MostrarUsuarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarUsuarios.Rows[e.RowIndex];

                int id_usuario = (int)selectedRow.Cells["Id"].Value;
                txtID.Text = id_usuario.ToString();
                Usuario usuario = usuarios.Find(u => u.id_usuario == id_usuario);

                inputUserNome.Text = usuario.Nome;
                inputUserEmail.Text = usuario.email;
                txtConfirEmail.Enabled = false;
                txtConfirSenha.Enabled = false;
                inputUserSenha.Enabled = false;

                // Carregue o nível de acesso correspondente
                CarregarNivelAcesso(id_usuario);
            }
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                int idUsuario = int.Parse(txtID.Text);
                userBLL.DesativarUsuario(idUsuario);
                MessageBox.Show("Usuario desativado com sucesso.");
                LoadUsuarios();
            }
            else
            {
                MessageBox.Show("Selecione um usuario para desativar.");
            }
        }
        private void btnAtivar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                int idUsuario = int.Parse(txtID.Text);
                userBLL.AtivarUsuario(idUsuario);
                MessageBox.Show("Usuario ativado com sucesso.");
                LoadUsuarios();
            }
            else
            {
                MessageBox.Show("Selecione um usuario para ativar novamente.");
            }
        }


        private void CarregarNivelAcesso(int idUsuario)
        {
            Usuario usuario = usuariosDesativados.Find(u => u.id_usuario == idUsuario);

            if (usuario != null)
            {
                ComboBoxAcesso.SelectedValue = usuario.UserAcesso;
            }
        }

        private void MostrarUsuariosDesativados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarUsuariosDesativados.Rows[e.RowIndex];

                int id_usuario = (int)selectedRow.Cells["Id_Desativado"].Value;
                txtID.Text = id_usuario.ToString();
                Usuario usuario = usuariosDesativados.Find(u => u.id_usuario == id_usuario);

                inputUserNome.Text = usuario.Nome;
                inputUserEmail.Text = usuario.email;
                txtConfirEmail.Enabled = false;
                txtConfirSenha.Enabled = false;
                inputUserSenha.Enabled = false;

                // Carregue o nível de acesso correspondente
                CarregarNivelAcesso(id_usuario);
            }
        }
    }
}

