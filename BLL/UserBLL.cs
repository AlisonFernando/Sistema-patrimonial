using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

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
        public List<Usuario> GetUsuarios()
        {
            return userDAL.GetUsuarios();
        }

        public void UpdateUsuario(Usuario usuario)
        {
            userDAL.UpdateUsuario(usuario);
        }

        public void DeleteUsuario(int id_usuario)
        {
            userDAL.DeleteUsuario(id_usuario);
        }

    }
}
