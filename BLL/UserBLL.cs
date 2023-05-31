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

        public string VerificarEmail(String verifemail)
        {
            UserDAL userDAL = new UserDAL();

            userDAL.VerificarEmail(verifemail);

            return "Este e-mail já existe, verifique e tente novamente";
        }
        
    }
}
