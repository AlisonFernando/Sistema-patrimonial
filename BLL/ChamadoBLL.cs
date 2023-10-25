using DAL;
using model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChamadoBLL
    {

        public string CadChamado(Chamado chamado, string emailUsuarioLogado)
        {
            ChamadoDAL chamadoDAL = new ChamadoDAL();

            chamadoDAL.CadastrarChamado(chamado, emailUsuarioLogado);

            return "Sucesso";
        }

        public DataTable ChamarEtiquetasDisponiveis()
        {
            ChamadoDAL chamadoDAL = new ChamadoDAL();

            return chamadoDAL.EscolherEtiquetasDisponiveis();
        }
        public DataTable EscolherNomeUsuario()
        {
            ChamadoDAL chamadoDAL = new ChamadoDAL();
            
            return  chamadoDAL.EscolherNomeUsuario();
        }

        public string BuscarNomeEquipamento(int idEquipamento)
        {
            ChamadoDAL chamadoDAL = new ChamadoDAL();
            return chamadoDAL.BuscarNomeEquipamento(idEquipamento);
        }

        public DataTable BuscarStatusChamado()
        {
            ChamadoDAL chamadoDAL = new ChamadoDAL();

            return chamadoDAL.BuscarStatusChamado();
        }
    }    
}
