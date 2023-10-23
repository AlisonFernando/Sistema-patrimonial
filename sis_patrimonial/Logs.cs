using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Logs
    {
        public int id_log { get; set; }
        public DateTime dateTime { get; set; }
        public string entidade { get; set; }
        public string operacao { get; set; }
        public string NomeUsuario { get; set; }
    }
}
