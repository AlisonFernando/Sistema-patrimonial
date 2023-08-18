using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Setor
    {
        public string nome;
        public int id_setor;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int ID_Setor
        {
            get { return id_setor; }
            set { id_setor = value; }
        }
    }
}
