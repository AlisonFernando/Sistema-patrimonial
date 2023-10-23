using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Logs
    {
        public int IdLog { get; set; }
        public DateTime DataHora { get; set; }
        public string Operacao { get; set; }
        public string Entidade { get; set; }
        public int IdUsuario { get; set; }
    }
}
