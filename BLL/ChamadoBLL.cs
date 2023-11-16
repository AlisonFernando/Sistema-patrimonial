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
        ChamadoDAL chamadoDAL = new ChamadoDAL();
        public string CadChamado(Chamado chamado, string emailUsuarioLogado)
        {
            chamadoDAL.CadastrarChamado(chamado, emailUsuarioLogado);
            return "Sucesso";
        }

        public DataTable ChamarEtiquetasDisponiveis()
        {
            return chamadoDAL.EscolherEtiquetasDisponiveis();
        }
        public DataTable EscolherNomeUsuario()
        {            
            return  chamadoDAL.EscolherNomeUsuario();
        }

        public (string NomeEquipamento, string NomeColaborador) BuscarNomeEquipamento(int idEquipamento)
        {
            return chamadoDAL.BuscarNomeEquipamento(idEquipamento);
        }


        public DataTable BuscarStatusChamado()
        {
            return chamadoDAL.BuscarStatusChamado();
        }
    }    
}
