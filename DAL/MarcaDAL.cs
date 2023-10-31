﻿using Dapper;
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

        public void InserirMarca(Marca marca, string emailUsuarioLogado)
        {
            string ativo = "0";
            if (marca.Ativo_inativo)
            {
                ativo = "1";
            }

            sql = "INSERT INTO tb_marca(Nome, Ativo_inativo) VALUES (@Nome, @Ativo_inativo) ";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@nome", marca.Nome);
            cmd.Parameters.AddWithValue("@ativo_inativo", ativo);


            cmd.ExecuteNonQuery();
            mConn.FecharConexao();

            // Inserir o registro de log na tabela tb_logs
            DateTime dataHoraAcao = DateTime.Now;
            string tipoOperacao = "cadastro de marca"; // Defina o tipo de operação conforme necessário

            sql = "INSERT INTO tb_logs(EmailUsuario, DataHoraAcao, TipoOperacao) VALUES (@EmailUsuario, @DataHoraAcao, @TipoOperacao)";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@EmailUsuario", emailUsuarioLogado);
            cmd.Parameters.AddWithValue("@DataHoraAcao", dataHoraAcao);
            cmd.Parameters.AddWithValue("@TipoOperacao", tipoOperacao);

            cmd.ExecuteNonQuery();
            mConn.FecharConexao();
        }
        public void UpdateMarca(Marca marca, string emailUsuarioLogado)
        {
            using (IDbConnection dbConnection = new MySqlConnection(conec))
            {
                dbConnection.Open();
                string query = "UPDATE tb_marca SET Nome, Ativo_inativo = @Nome, @Ativo_inativo WHERE id_marca = @id_marca";
                dbConnection.Execute(query, marca);

                mConn.FecharConexao();

                // Inserir o registro de log na tabela tb_logs
                DateTime dataHoraAcao = DateTime.Now;
                string tipoOperacao = "atualização de marca"; // Defina o tipo de operação conforme necessário

                sql = "INSERT INTO tb_logs(EmailUsuario, DataHoraAcao, TipoOperacao) VALUES (@EmailUsuario, @DataHoraAcao, @TipoOperacao)";
                cmd = new MySqlCommand(sql, mConn.AbrirConexao());

                cmd.Parameters.AddWithValue("@EmailUsuario", emailUsuarioLogado);
                cmd.Parameters.AddWithValue("@DataHoraAcao", dataHoraAcao);
                cmd.Parameters.AddWithValue("@TipoOperacao", tipoOperacao);

                cmd.ExecuteNonQuery();
                mConn.FecharConexao();
            }
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
            string sql = "SELECT * FROM tb_marca WHERE Ativo_inativo = 1"; // Filtra marcas ativas (Ativo_inativo = 1)

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
        public List<Marca> GetMarcasAtivas()
        {

            using (IDbConnection dbConnection = new MySqlConnection(conec))
            {
                dbConnection.Open();
                return dbConnection.Query<Marca>("SELECT id_marca, Nome FROM tb_marca WHERE Ativo_inativo = 1").ToList();
            }
        }
        public List<Marca> GetMarcasDesativadas()
        {

            using (IDbConnection dbConnection = new MySqlConnection(conec))
            {
                dbConnection.Open();
                return dbConnection.Query<Marca>("SELECT id_marca, Nome FROM tb_marca WHERE Ativo_inativo = 0").ToList();
            }
        }


        public void DesativarMarca(int idMarca)
        {
            using (IDbConnection dbConnection = new MySqlConnection(conec))
            {
                dbConnection.Open();
                string query = "UPDATE tb_marca SET Ativo_inativo = 0 WHERE id_marca = @IdMarca";
                dbConnection.Execute(query, new { IdMarca = idMarca });
            }
        }
        public void AtivarMarca(int idMarca)
        {
            using (IDbConnection dbConnection = new MySqlConnection(conec))
            {
                dbConnection.Open();
                string query = "UPDATE tb_marca SET Ativo_inativo = 1 WHERE id_marca = @IdMarca";
                dbConnection.Execute(query, new { IdMarca = idMarca });
            }
        }


    }
}
