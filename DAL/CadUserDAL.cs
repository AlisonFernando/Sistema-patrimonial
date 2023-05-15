using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace DAL
{
    public class CadUserDAL
    {
        ConexaoDB mConn = new ConexaoDB();
        string sql;
        MySqlCommand cmd;

        public void InserirUsuario(Usuario usuario)
        {
            mConn.AbrirConexao();
            sql = "INSERT INTO tb_usuario(Nome, Email, Senha) VALUES (@Nome, @Email, @Senha) ";
            cmd = new MySqlCommand(sql, mConn.mConn);

            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@email", usuario.Email);
            cmd.Parameters.AddWithValue("@senha", usuario.Senha);

            cmd.ExecuteNonQuery();
        }
    }
}
