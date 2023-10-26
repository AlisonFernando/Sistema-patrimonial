using BLL;
using model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class TelaEsqueciSenha : Form
    {
        Usuario usuario = new Usuario();
        private UserBLL userBLL = new UserBLL();
        private List<Usuario> usuarios = new List<Usuario>();
        public TelaEsqueciSenha()
        {
            InitializeComponent();
        }
        private void TelaEsqueciSenha_Load(object sender, EventArgs e)
        {
            LoadUsuarios();
        }
        public void LoadUsuarios()
        {
            usuarios = userBLL.GetUsuarios();
            MostrarUsuarios.DataSource = usuarios;
        }

        private void MostrarUsuarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = MostrarUsuarios.Rows[e.RowIndex];

                int id_usuario = (int)selectedRow.Cells["ID"].Value;
                Usuario usuario = usuarios.Find(u => u.id_usuario == id_usuario);

                txtID.Text = usuario.id_usuario.ToString();
                txtEmail.Text = usuario.Email.ToString();

            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            usuario.Email = txtEmail.Text;

            if (string.IsNullOrEmpty(usuario.Email))
            {
                MessageBox.Show("Por favor, insira um endereço de e-mail válido.");
                return;
            }

            UserBLL userBLL = new UserBLL();
            string verificar = userBLL.VerificarEmail(usuario.Email);

            if (verificar == "Email existente")
            {
                int idUsuario = userBLL.ObterIdUsuarioPorEmail(usuario.Email);
                if (idUsuario > 0)
                {
                    string tokenRecuperacao = Guid.NewGuid().ToString();
                    DateTime dataExpiracao = DateTime.Now.AddHours(24);
                    DateTime dataCriacao = DateTime.Now;
                    // Salve o token no banco de dados associado a este usuário
                    if (userBLL.GerarEInserirTokenRecuperacao(idUsuario, tokenRecuperacao, dataExpiracao, dataCriacao))
                    {
                        // Envie um e-mail para o usuário com um link contendo o token de recuperação
                        EnviarEmailRecuperacao(usuario.Email, tokenRecuperacao);

                        MessageBox.Show("Um e-mail de recuperação foi enviado para o seu endereço.");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao gerar o token de recuperação. Por favor, tente novamente.");
                    }
                }
            }
            else
            {
                MessageBox.Show("O e-mail não existe, tente novamente.");
            }
        }


        private void EnviarEmailRecuperacao(string destinatarioEmail, string tokenRecuperacao)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"); // Substitua pelo servidor SMTP do seu provedor
                smtpClient.Port = 587; // Substitua pela porta do seu provedor SMTP
                smtpClient.Credentials = new NetworkCredential("recuperarsenhascot@gmail.com", "yuzq olkd dofn pcoy"); // Substitua com suas credenciais
                smtpClient.EnableSsl = true; // Use SSL se disponível no seu provedor SMTP

                MailMessage mensagem = new MailMessage("recuperarsenhascot@gmail.com", destinatarioEmail);
                mensagem.Subject = "Recuperação de Senha";
                mensagem.Body = "Token de recuperação de senha:" + tokenRecuperacao; // Substitua pelo link e token real
                mensagem.IsBodyHtml = false;

                smtpClient.Send(mensagem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao enviar o e-mail de recuperação: " + ex.Message);
            }
        }


        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string emailPesquisado = txtPesquisar.Text.Trim();

            List<Usuario> usuariosFiltrados = usuarios
                .Where(usuario => usuario.Email.Contains(emailPesquisado, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (usuariosFiltrados.Count == 0)
            {
                MessageBox.Show("Usuario não encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (emailPesquisado == string.Empty)
            {
                MessageBox.Show("Digite um usuario válido e tente novamente");
                txtPesquisar.Focus();
            }
            else
            {
                MostrarUsuarios.DataSource = usuariosFiltrados;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Text = string.Empty;
            txtEmail.Text = string.Empty;
            LoadUsuarios();
        }

        private void btnRedefinirSenha_Click(object sender, EventArgs e)
        {
            string token = txtToken.Text;
            string novaSenha = txtSenhaNova.Text;

            if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(novaSenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            int idUsuario = userBLL.ObterIdUsuarioPorEmail(usuario.Email); // Obtenha o id do usuário
            if (idUsuario > 0)
            {
                UserBLL userBLL = new UserBLL();
                bool tokenValido = userBLL.VerificarTokenRecuperacaoValido(idUsuario, token);

                if (tokenValido)
                {
                    bool sucesso = userBLL.RedefinirSenha(idUsuario, novaSenha);

                    if (sucesso)
                    {
                        MessageBox.Show("Sua senha foi redefinida com sucesso.");
                        LoadUsuarios();
                        txtEmail.Text = string.Empty;
                        txtToken.Text = string.Empty;
                        txtSenhaNova.Text = string.Empty;
                        txtPesquisar.Text = string.Empty;
                        // Aqui você pode redirecionar o usuário para a página de login ou executar outras ações necessárias.
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao redefinir a senha. Por favor, tente novamente.");
                    }
                }
                else
                {
                    MessageBox.Show("O token de recuperação não é válido ou expirou. Por favor, solicite um novo token de recuperação.");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
