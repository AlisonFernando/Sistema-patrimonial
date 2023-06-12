using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using model;

namespace BLL
{
    public class LoginBLL
    {
        public string ValidarEmail(string validarEmail)
        {
            LoginDAL loginDAL = new LoginDAL();
            bool emailExists = loginDAL.ValidarEmailLogin(validarEmail);

            if (emailExists)
            {
                return "Email correto";
            }
            else
            {
                return "Email incorreto";
            }
        }
        public string ValidarSenha(string validarSenha) {

            LoginDAL loginDAL = new LoginDAL();
            bool senhaExists = loginDAL.ValidarSenhaLogin(validarSenha);

            if (senhaExists)
            {
                return "Senha correta";
            }
            else
            {
                return "Senha incorreta";
            }

        }
    }
}
