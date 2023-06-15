using DAL;
using model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EquipamentoBLL
    {
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
    }
}
