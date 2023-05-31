using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace DAL
{
    public class UserDAL
    {
        ConexaoDB mConn = new ConexaoDB();
        string sql;
        MySqlCommand cmd;

        public void InserirUsuario(Usuario usuario)
        {
            
            sql = "INSERT INTO tb_usuario(Nome, Email, Senha) VALUES (@Nome, @Email, @Senha) ";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@email", usuario.Email);
            cmd.Parameters.AddWithValue("@senha", usuario.Senha);

            cmd.ExecuteNonQuery();
            mConn.FecharConexao();
        }

        public bool VerificarEmail(String email)
        {

            sql = "select Email from tb_usuario WHERE Email = '"+email+"'";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());


            cmd.Parameters.AddWithValue("@email", email);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if(count > 0)
            {
                return true;
              
            }
            else
            {
                return false;
            }


        }
    }
}
