using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Marca
    {
        public string nome;
        public int id_marca;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int ID_Marca
        {
            get { return id_marca; }
            set { id_marca = value; }
        }
    }
}
