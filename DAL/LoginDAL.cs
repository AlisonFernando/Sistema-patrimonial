using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace DAL
{
    public class LoginDAL
    {
        ConexaoDB mConn = new ConexaoDB();
        string sql;
        MySqlCommand cmd;

        public bool ValidarEmailLogin(String email)
        {
            bool emailExists = false;
            string sql = "SELECT COUNT(*) FROM tb_usuario WHERE Email = @email";

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        emailExists = true;
                    }
                }
            }
            return emailExists;
        }

        public bool ValidarSenhaLogin(String senha)
        {
            bool senhaExists = false;
            string sql = "SELECT COUNT(*) FROM tb_usuario WHERE Senha = @senha";

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@senha", senha);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        senhaExists = true;
                    }
                }
            }
            return senhaExists;
        }
    }
}
