using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StatusBLL
    {
        public DataTable CarregarStatus()
        {
            StatusDAL statusDAL = new StatusDAL();
            DataTable resultado = statusDAL.CarregarStatus();
            return resultado;
        }
    }
}
