using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Chamado
    {
        public string descricao;
        public string equipamento_id { get; set; }
        public string colaborador_id { get; set; }
        public DateTime DataHora { get; set; }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}
