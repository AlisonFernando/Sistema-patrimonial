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
    public class SetorDAL
    {
        public string conec = "Persist Security Info = False; server=syspatrimonial.mysql.dbaas.com.br;database=syspatrimonial;uid=syspatrimonial;pwd=Alison17@;";
        string sql;
        MySqlCommand cmd;
        ConexaoDB mConn = new ConexaoDB();

        public DataTable ConsultarSetor()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM tb_setor";

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

        public void InserirSetor(Setor setor)
        {

            sql = "INSERT INTO tb_setor(Nome_setor) VALUES " +
                    "(@Nome_setor)";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@Nome_setor", setor.nome);

            cmd.ExecuteNonQuery();
            mConn.FecharConexao();
        }
        public List<Setor> GetSetor()
        {

            using (IDbConnection dbConnection = new MySqlConnection(conec))
            {
                dbConnection.Open();
                return dbConnection.Query<Setor>("SELECT ID_setor, Nome_setor AS Nome FROM tb_setor").ToList();
            }
        }
        public bool VerificarSetor(String nomeSetor)
        {
            bool setorExists = false;
            string sql = "SELECT COUNT(*) FROM tb_setor WHERE Nome_setor = @nome";

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nome", nomeSetor);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        setorExists = true;
                    }
                }
            }
            return setorExists;
        }
        public void UpdateSetor(Setor setor)
        {
            using (IDbConnection dbConnection = new MySqlConnection(conec))
            {
                dbConnection.Open();
                string query = "UPDATE tb_setor SET Nome_setor = @nome WHERE ID_Setor = @id_Setor";
                dbConnection.Execute(query, setor);
            }
        }
        public void DeleteSetor(int ID_Setor)
        {
            using (IDbConnection dbConnection = new MySqlConnection(conec))
            {
                dbConnection.Open();
                string query = "DELETE FROM tb_setor WHERE ID_setor = @ID_Setor";
                dbConnection.Execute(query, new { ID_Setor });
            }
        }
    }
}
