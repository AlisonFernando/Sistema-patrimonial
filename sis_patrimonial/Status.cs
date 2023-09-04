using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Status
    {
        public string andamento_chamado;
        public int id_status { get; set; }

       public string Andamento_Chamado
        {
            get { return andamento_chamado; }
            set { andamento_chamado = value; }
        }

    }
}
