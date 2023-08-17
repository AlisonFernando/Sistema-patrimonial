using DAL;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ColaboradorBLL
    {
        public string CadColab(Colaborador colaborador)
        {
            ColaboradorDAL colaboradorDAL = new ColaboradorDAL();

            colaboradorDAL.InserirColaborador(colaborador);

            return "Sucesso";
        }

        public string VerificarNome(string verifnome)
        {
            ColaboradorDAL colaboradorDAL = new ColaboradorDAL();
            bool nomeExists = colaboradorDAL.VerificarNome(verifnome);

            if (nomeExists)
            {
                return "nome existente";
            }
            else
            {
                return "nome não existe";
            }

        }
    }
}
