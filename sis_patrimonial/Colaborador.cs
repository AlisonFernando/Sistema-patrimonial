using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Colaborador
    {
        string emailColaborador;
        string nomeColaborador;
        string senhaColaborador;
        string agendaColaborador;
        string telefoneColaborador;
        public bool ativo;
        public string id_setor { get; set; }
        public string SenhaHash { get; set; }


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

        [EmailAddress]
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
