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
    public class MarcaBLL
    {
        public string CadMarca(Marca marca, string emailUsuarioLogado)
        {
            MarcaDAL marcaDAL = new MarcaDAL();

            marcaDAL.InserirMarca(marca, emailUsuarioLogado);

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

        public DataTable CarregarMarcas()
        {
            MarcaDAL marcaDAL = new MarcaDAL();
            DataTable resultado = marcaDAL.ConsultarMarca();
            return resultado;
        }

        public List<Marca> GetMarcas()
        {
            MarcaDAL marcaDAL = new MarcaDAL();
            return marcaDAL.GetMarcas();
        }

    }
}
