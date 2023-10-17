using Dapper;
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
        public string conec = "Persist Security Info = False; server=syspatrimonial.mysql.dbaas.com.br;database=syspatrimonial;uid=syspatrimonial;pwd=Alison17@;";

        public void InserirMarca(Marca marca)
        {

            sql = "INSERT INTO tb_marca(Nome) VALUES (@Nome) ";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@nome", marca.Nome);


            cmd.ExecuteNonQuery();
            mConn.FecharConexao();
        }

        public bool VerificarMarca(String nomeMarca)
        {
            bool marcaExists = false;
            string sql = "SELECT COUNT(*) FROM tb_marca WHERE Nome = @nome";

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

        public DataTable ConsultarMarca()
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
        public List<Marca> GetMarcas()
        {

            using (IDbConnection dbConnection = new MySqlConnection(conec))
            {
                dbConnection.Open();
                return dbConnection.Query<Marca>("SELECT id_marca, Nome FROM tb_marca").ToList();
            }
        }

    }
}
