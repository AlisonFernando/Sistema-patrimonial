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
        public bool VerificarCredenciais(string usuario, string senha)
        {
            string senhaCriptografadaDoBanco = userDAL.ObterSenhaCriptografada(usuario);

            if (senhaCriptografadaDoBanco != null)
            {
                return BCrypt.Net.BCrypt.Verify(senha, senhaCriptografadaDoBanco);
            }

            return false;
        }
        public List<Usuario> GetUsuarios()
        {

            return userDAL.GetUsuarios();
        }

        public string UpdateUsuario(Usuario usuario, string emailUsuarioLogado)
        {
            userDAL.UpdateUsuario(usuario, emailUsuarioLogado);

            return "Sucesso";
        }

        public void DeleteUsuario(int id_usuario, Usuario usuario, string emailUsuarioLogado)
        {
            userDAL.DeleteUsuario(id_usuario, usuario, emailUsuarioLogado);
        }
        public void AtualizarSenha(Usuario usuario)
        {
            // Criptografar a senha com BCrypt
            string senhaCriptografada = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
            usuario.Senha = senhaCriptografada;

            userDAL.UpdateUsuario(usuario, senhaCriptografada);
        }
        public int ObterUserChamado(string email)
        {
            return userDAL.ObterUserChamado(email);
        }
    }
}
