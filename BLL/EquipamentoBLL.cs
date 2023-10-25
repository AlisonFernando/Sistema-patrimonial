using DAL;
using model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EquipamentoBLL
    {
        private EquipamentoDAL equipamentoDAL = new EquipamentoDAL();
        public string CadEquip(Equipamento equipamento, string emailUsuarioLogado)
        {
            EquipamentoDAL equipamentoDAL = new EquipamentoDAL();

            equipamentoDAL.InserirEquipamento(equipamento, emailUsuarioLogado);

            return "Sucesso";
        }

        public string VerificarEtiqueta(string verifetiqueta)
        {
            EquipamentoDAL equipamentoDAL = new EquipamentoDAL();
            bool etiquetaExists = equipamentoDAL.VerificarEtiqueta(verifetiqueta);

            if (etiquetaExists)
            {
                return "Etiqueta existente";
            }
            else
            {
                return "Etiqueta não existe";
            }
           
        }
        public List<Equipamento> GetEquipamentosDisponiveis()
        {

            return equipamentoDAL.GetEquipamentosDisponiveis();
        }
        public List<Equipamento> GetEquipamentos()
        {

            return equipamentoDAL.GetEquipamentos();
        }

        public string UpdateEquipamentos(Equipamento equipamento, string emailUsuarioLogado)
        {
            equipamentoDAL.UpdateEquipamentos(equipamento, emailUsuarioLogado);

            return "Sucesso";
        }

        public void DeleteEquipamento(int ID_equipamento, string emailUsuarioLogado)
        {
            equipamentoDAL.DeleteEquipamento(ID_equipamento, emailUsuarioLogado);
        }

        public List<Equipamento> ObterEquipamentos()
        {
           return equipamentoDAL.GetEquipamentosRelatorio();
        }

    }
}
