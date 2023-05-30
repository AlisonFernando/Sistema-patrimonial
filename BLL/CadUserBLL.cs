using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class CadUserBLL
    {
        public string CadUser(Usuario usuario)
        {
            UserDAL userDAL = new UserDAL();

            userDAL.InserirUsuario(usuario);

            return "Sucesso";
        }
        
    }
}
