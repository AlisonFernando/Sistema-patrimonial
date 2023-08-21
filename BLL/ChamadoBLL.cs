using DAL;
using model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChamadoBLL
    {
        public string CadChamado(Chamado chamado)
        {
            ChamadoDAL chamadoDAL = new ChamadoDAL();

            chamadoDAL.CadastrarChamado(chamado);

            return "Sucesso";
        }

        public DataTable ChamarEtiquetas()
        {
            ChamadoDAL chamadoDAL = new ChamadoDAL();

            return chamadoDAL.EscolherEtiqueta();
        }
    }
}
