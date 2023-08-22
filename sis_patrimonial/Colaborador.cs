using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Colaborador
    {
        string nomeColaborador;
        string emailColaborador;
        string telefoneColaborador;
        string agendaColaborador;
        public bool ativo;
        string senhaColaborador;
        public string setor_id { get; set; }
        public string equipamento_id { get; set; }


        public string NomeColaborador
        {
            get { return nomeColaborador; }
            set { nomeColaborador = value; }
        }
        public string AgendaColaborador
        {
            get { return agendaColaborador; }
            set { agendaColaborador = value; }
        }

        public string TelefoneColaborador
        {
            get { return telefoneColaborador; }
            set { telefoneColaborador = value; }
        }       

        public bool Ativo_inativo
        {
            get { return ativo; }
            set { ativo = value; }
        }
        public string EmailColaborador
        {
            get { return emailColaborador; }
            set { emailColaborador = value; }
        }
        public string SenhaColaborador
        {
            get { return senhaColaborador; }
            set {  senhaColaborador = value;}
        }
    }
}
