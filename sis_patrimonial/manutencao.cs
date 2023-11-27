using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Manutencao
    {
        public int id_chamado { get; set; }

        public DateTime DataChamado { get; set; }

        public string Descricao { get; set; }

        public int id_usuario { get; set; }

        public int id_status { get; set; }

        public string id_equipamento { get; set; }

        public string NomeEquipamento { get; set; }

        public string NomeUsuario { get; set; }

        public int id_colaborador { get; set; }

        public string NomeColaborador { get; set; }

        //public string AndamentoChamado { get; set; }
    }
}
