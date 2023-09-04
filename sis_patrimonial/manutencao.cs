using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class manutencao
    {
        public int id_manutencao {get; set;}
        public int id_equipamento { get; set;}

        public bool finalizado;

        public string motivo_manutencao;




        public bool Finalizado
        {
            get { return finalizado; }
            set { finalizado = value; }
        }

        public string Manutencao
        {
            get { return motivo_manutencao; }
            set { motivo_manutencao = value; }
        }
    }
}
