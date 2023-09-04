using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Chamado
    {
        public int id_chamado { get; set; }

        public string descricao;
        public string id_equipamento { get; set; }
        public int id_usuario { get; set; }
        public int id_status { get; set; }
        public DateTime DataHora { get; set; }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}
