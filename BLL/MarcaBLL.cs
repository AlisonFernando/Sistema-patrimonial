using DAL;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MarcaBLL
    {
        public string CadMarca(Marca marca)
        {
            MarcaDAL marcaDAL = new MarcaDAL();

            marcaDAL.InserirMarca(marca);

            return "Sucesso";
        }

        public string VerificarMarca(string verifmarca)
        {
            MarcaDAL marcaDAL = new MarcaDAL();
            bool marcaExists = marcaDAL.VerificarMarca(verifmarca);

            if (marcaExists)
            {
                return "Marca existente";
            }
            else
            {
                return "Marca não existe";
            }
        }
    }
}
