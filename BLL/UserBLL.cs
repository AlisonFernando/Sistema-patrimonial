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

    }
}
