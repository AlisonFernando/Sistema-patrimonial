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
        string sql_email;
        MySqlCommand cmd;

        public void InserirUsuario(Usuario usuario)
        {
            ;
            sql = "INSERT INTO tb_usuario(Nome, Email, Senha) VALUES (@Nome, @Email, @Senha) ";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@email", usuario.Email);
            cmd.Parameters.AddWithValue("@senha", usuario.Senha);

            cmd.ExecuteNonQuery();
            mConn.FecharConexao();
        }


        /*public void VerificarEmail(Usuario verificarEmail)
        {
            mConn.AbrirConexao();
            sql_email = "SELECT Email FROM tb_usuario";
            cmd = new MySqlCommand(sql_email, mConn.mConn);
        }*/
    }
}
