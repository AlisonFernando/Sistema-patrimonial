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
            string ativo = "0";
            if (setor.Ativo_inativo)
            {
                ativo = "1";
            }

            sql = "INSERT INTO tb_setor(Nome_setor) VALUES " +
                    "(@Nome_setor)";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@Nome_setor", setor.nome);
            cmd.Parameters.AddWithValue("@ativo_inativo", ativo);

            cmd.ExecuteNonQuery();
            mConn.FecharConexao();
        }
        public List<Setor> GetSetor()
        {
            using (IDbConnection dbConnection = mConn.AbrirConexao())
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
            using (IDbConnection dbConnection = mConn.AbrirConexao())
            {
                dbConnection.Open();
                string query = "UPDATE tb_setor SET Nome_setor = @Nome WHERE ID_setor = @ID_setor";
                dbConnection.Execute(query, setor);
            }
        }

        public void DesativarSetor(int id_setor)
        {
            using (IDbConnection dbConnection = mConn.AbrirConexao())
            {
                dbConnection.Open();
                string query = "UPDATE tb_setor SET Ativo_inativo = 0 WHERE ID_setor = @ID_setor";
                int rowsAffected = dbConnection.Execute(query, new { ID_setor });

                if (rowsAffected > 0)
                {
                    // Atualização bem-sucedida
                    // Aqui você pode adicionar lógica adicional se necessário
                }
                else
                {
                    // A atualização não teve efeito (nenhuma marca encontrada com o ID especificado, por exemplo)
                    // Adicione lógica apropriada, se necessário
                }
            }
        }
        public void AtivarSetor(int id_setor)
        {
            using (IDbConnection dbConnection = mConn.AbrirConexao())
            {
                dbConnection.Open();
                string query = "UPDATE tb_setor SET Ativo_inativo = 1 WHERE ID_setor = @ID_setor";
                int rowsAffected = dbConnection.Execute(query, new { ID_setor });

                if (rowsAffected > 0)
                {
                    // Atualização bem-sucedida
                    // Aqui você pode adicionar lógica adicional se necessário
                }
                else
                {
                    // A atualização não teve efeito (nenhuma marca encontrada com o ID especificado, por exemplo)
                    // Adicione lógica apropriada, se necessário
                }
            }
        }

        public List<Setor> GetSetorAtivo()
        {
            using (IDbConnection dbConnection = mConn.AbrirConexao())
            {
                dbConnection.Open();
                return dbConnection.Query<Setor>("SELECT ID_setor, Nome_setor AS Nome FROM tb_setor WHERE Ativo_inativo = 1").ToList();
            }
        }

        public List<Setor> GetSetorDesativado()
        {
            using (IDbConnection dbConnection = mConn.AbrirConexao())
            {
                dbConnection.Open();
                return dbConnection.Query<Setor>("SELECT ID_setor, Nome_setor AS Nome FROM tb_setor WHERE Ativo_inativo = 0").ToList();
            }
        }
    }
}
