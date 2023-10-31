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
        MarcaDAL marcaDAL = new MarcaDAL();
        public string CadMarca(Marca marca, string emailUsuarioLogado)
        {
            marcaDAL.InserirMarca(marca, emailUsuarioLogado);

            return "Sucesso";
        }
        public string UpdateMarca(Marca marca, string emailUsuarioLogado)
        {
            marcaDAL.UpdateMarca(marca, emailUsuarioLogado);

            return "Sucesso";
        }

        public string VerificarMarca(string verifmarca)
        {
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
            DataTable resultado = marcaDAL.ConsultarMarca();
            return resultado;
        }

        public List<Marca> GetMarcasAtivas()
        {
            return marcaDAL.GetMarcasAtivas();
        }
        public List<Marca> GetMarcasDesativadas()
        {
            return marcaDAL.GetMarcasDesativadas();
        }

        public void DesativarMarca(int idMarca)
        {
            marcaDAL.DesativarMarca(idMarca);
        }
        public void AtivarMarca(int idMarca)
        {
            marcaDAL.AtivarMarca(idMarca);
        }


    }
}
