using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SetorBLL
    {
        public DataTable CarregarSetor()
        {
            SetorDAL setorDAL = new SetorDAL();
            DataTable resultado = setorDAL.ConsultarSetor();
            return resultado;
        }
    }
}
