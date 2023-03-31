using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Login
    {
        private string email;
        private string password;
        
       public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password { 
            get { return password; }
            set { password = value; }
        }
    }
}
