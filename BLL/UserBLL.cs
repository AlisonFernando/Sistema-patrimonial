using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Net.Mail;

namespace BLL
{
    public class UserBLL
    {
        
        private UserDAL userDAL = new UserDAL();

        public string CadUser(Usuario usuario, string emailUsuarioLogado)
        {
            userDAL.InserirUsuario(usuario, emailUsuarioLogado); // Insira o novo usuário e passe o email do usuário logado

            return "Sucesso";
        }

        public string VerificarEmail(string verifemail)
        {
            UserDAL userDAL = new UserDAL();
            bool emailExists = userDAL.VerificarEmail(verifemail);

            if (emailExists)
            {
                return "Email existente";
            }
            else
            {
                return "Email não existe";
            }
        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public bool VerificarCredenciais(string email, string senha)
        {
            Usuario usuario = userDAL.ObterUsuario(email);

            if (usuario != null)
            {
                // Verificar se o usuário está ativo
                if (usuario.Ativo_inativo)
                {
                    string senhaCriptografadaDoBanco = userDAL.ObterSenhaCriptografada(email);

                    if (senhaCriptografadaDoBanco != null)
                    {
                        // Verificar a senha
                        if (BCrypt.Net.BCrypt.Verify(senha, senhaCriptografadaDoBanco))
                        {
                            return true; // Credenciais válidas
                        }
                    }
                }
                else
                {
                    // Usuário desativado
                    return false;
                }
            }

            // Usuário não encontrado ou credenciais inválidas
            return false;
        }

        public List<Usuario> GetUsuarios()
        {

            return userDAL.GetUsuarios();
        }
        public List<Usuario> GetUsuariosAtivos()
        {
            return userDAL.GetUsuariosAtivos();
        }
        public List<Usuario> GetUsuariosDesativados()
        {
            return userDAL.GetUsuariosDesativados();
        }

        public string UpdateUsuario(Usuario usuario, string emailUsuarioLogado)
        {
            userDAL.UpdateUsuario(usuario, emailUsuarioLogado);

            return "Sucesso";
        }

        public void DesativarUsuario(int id_usuario)
        {
            userDAL.DesativarUsuario(id_usuario);
        }
        public void AtivarUsuario(int id_usuario)
        {
            userDAL.AtivarUsuario(id_usuario);
        }


        /*public void AtualizarSenha(Usuario usuario)
        {
            // Criptografar a senha com BCrypt
            string senhaCriptografada = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
            usuario.Senha = senhaCriptografada;

            userDAL.UpdateUsuario(usuario, senhaCriptografada);
        }*/

        public int ObterUserChamado(string email)
        {
            return userDAL.ObterUserChamado(email);
        }

        public bool GerarEInserirTokenRecuperacao(int idUsuario, string token, DateTime dataExpiracao, DateTime dataCriacao, string emailUsuarioLogado)
        {

            UserDAL userDAL = new UserDAL();
            return userDAL.InserirTokenRecuperacao(idUsuario, token, dataExpiracao, dataCriacao, emailUsuarioLogado);
        }

        public bool VerificarTokenRecuperacaoValido(int idUsuario, string token)
        {
            UserDAL userDAL = new UserDAL();

            return userDAL.VerificarTokenRecuperacaoValido(idUsuario, token);
        }

        public bool RedefinirSenha(int idUsuario, string novaSenha, string emailUsuarioLogado)
        {
            string senhaCriptografada = userDAL.HashPassword(novaSenha); // Gere a nova senha criptografada

            return userDAL.AtualizarSenha(idUsuario, senhaCriptografada, emailUsuarioLogado);
        }

        
        public int ObterIdUsuarioPorEmail(string email)
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.ObterIdUsuarioPorEmail(email);
        }

    }
}
