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
        public string CadEquip(Equipamento equipamento)
        {
            EquipamentoDAL equipamentoDAL = new EquipamentoDAL();

            equipamentoDAL.InserirEquipamento(equipamento);

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
        public DataTable ChamarEquipamentos()
        {
            EquipamentoDAL equipamentoDAL = new EquipamentoDAL();

            return equipamentoDAL.EscolherEquipamentos();
        }

        public List<Equipamento> GetEquipamentos()
        {

            return equipamentoDAL.GetEquipamentos();
        }

        public string UpdateEquipamentos(Equipamento equipamento)
        {
            equipamentoDAL.UpdateEquipamentos(equipamento);

            return "Sucesso";
        }

        public void DeleteEquipamento(int ID_equipamento)
        {
            equipamentoDAL.DeleteEquipamento(ID_equipamento);
        }
    }
}
