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
        StatusDAL statusDAL = new StatusDAL();
        public DataTable CarregarStatus()
        {
            DataTable resultado = statusDAL.CarregarStatus();
            return resultado;
        }
        public bool AtualizarStatusEquipamento(int id_equipamento, int idStatus)
        {
            // Chame o método na camada de dados
            return statusDAL.AtualizarStatusEquipamento(id_equipamento, idStatus);
        }
    }
}
