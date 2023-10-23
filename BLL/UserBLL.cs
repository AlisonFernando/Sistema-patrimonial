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
        public string CadUser(Usuario usuario)
        {
            UserDAL userDAL = new UserDAL();

            userDAL.InserirUsuario(usuario);

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

        public string UpdateUsuario(Usuario usuario)
        {
            userDAL.UpdateUsuario(usuario);

            return "Sucesso";
        }

        public void DeleteUsuario(int id_usuario)
        {
            userDAL.DeleteUsuario(id_usuario);
        }
        public void AtualizarSenha(Usuario usuario)
        {
            // Criptografar a senha com BCrypt
            string senhaCriptografada = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
            usuario.Senha = senhaCriptografada;

            userDAL.UpdateUsuario(usuario);
        }
        public int ObterUserChamado(string email)
        {
            return userDAL.ObterUserChamado(email);
        }
    }
}
