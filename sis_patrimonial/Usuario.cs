using System;
using System.Collections.Generic;
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

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email {
            get { return email; }
            set { email = value; }
        }
        public string Senha {
            get { return senha; }
            set { senha = value; }
        }


    }
}
