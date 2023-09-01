using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Login
    {
        public string email;
        public string senha;
        

        [EmailAddress]
       public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Senha { 
            get { return senha; }
            set { senha = value; }
        }
    }
}
