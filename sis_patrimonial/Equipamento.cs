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
        public string id_marca { get; set; }
        public string id_colaborador { get; set; }
        public int ID_equipamento { get; set; }
        public int id_status {get; set;}
        

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
