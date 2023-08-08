using model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MarcaDAL
    {
        ConexaoDB mConn = new ConexaoDB();
        string sql;
        MySqlCommand cmd;

        public void InserirMarca(Marca marca)
        {

            sql = "INSERT INTO tb_marca(Nome_marca) VALUES (@Nome) ";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@nome", marca.Nome);


            cmd.ExecuteNonQuery();
            mConn.FecharConexao();
        }

        public bool VerificarMarca(String nomeMarca)
        {
            bool marcaExists = false;
            string sql = "SELECT COUNT(*) FROM tb_marca WHERE Nome_marca = @nome";

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nome", nomeMarca);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        marcaExists = true;
                    }
                }
            }
            return marcaExists;
        }

        public DataTable ConsultarMarca(Marca marca)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM tb_marca";

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }
        
    }
}
