using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Usuario
    {
        public string nome;
        public string email;
        public string senha;
        public string confirmEmail;
        public string confirmSenha;
        public string SenhaHash { get; set; }
        public int id_usuario { get; set; }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        [EmailAddress]
        public string Email {
            get { return email; }
            set { email = value; }
        }
        public string Senha {
            get { return senha; }
            set { senha = value; }
        }

        public string ConfirmarSenha
        {   get { return confirmEmail; }
            set { confirmEmail = value; }
        }

        public string ConfirmarEmail
        {
            get { return confirmSenha; }
            set { confirmSenha = value; }
        }
    }
}
