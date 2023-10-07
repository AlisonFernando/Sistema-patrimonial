using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class manutencao
    {
        public int id_status { get; set;}

        public string descricao;
        public string Nome_equipamento { get; set;}
        public int ID_equipamento { get; set;}
        public string status {  get; set;}

        public string andamento_do_chamado { get; set;}

    }
}
