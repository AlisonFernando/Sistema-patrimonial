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
    public class SetorBLL
    {
        SetorDAL setorDAL = new SetorDAL();
        public DataTable CarregarSetor()
        {
            DataTable resultado = setorDAL.ConsultarSetor();
            return resultado;
        }
        public string CadSetor(Setor setor)
        {            
            setorDAL.InserirSetor(setor);
            return "Sucesso";
        }
        public List<Setor> GetSetor()
        {

            return setorDAL.GetSetor();
        }
        public string VerificarNome(string verifNome)
        {
            bool setorExists = setorDAL.VerificarSetor(verifNome);

            if (setorExists)
            {
                return "Setor existente";
            }
            else
            {
                return "Setor não existe";
            }
        }
        public string UpdateSetor(Setor setor)
        {
            setorDAL.UpdateSetor(setor);

            return "Sucesso";
        }
        public void DesativarSetor(int id_setor)
        {
            setorDAL.DesativarSetor(id_setor);
        }
        public void AtivarSetor(int id_setor)
        {
            setorDAL.AtivarSetor(id_setor);
        }
        public List<Setor> GetSetorAtivo()
        {
            return setorDAL.GetSetorAtivo();
        }
        public List<Setor> GetSetorDesativado()
        {
            return setorDAL.GetSetorDesativado();
        }
    }
}
