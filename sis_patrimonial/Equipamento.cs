using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Equipamento
    {
        public string nome;
        public string descricao;
        public string valor;
        public string etiqueta;
        public bool ativo;
        public string marca_id { get; set; }
        public string colaborador_id { get; set; }


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public bool Ativo_inativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }               
        public string Etiqueta
        {
            get { return etiqueta; }
            set { etiqueta = value; }
        }        
    }
}
