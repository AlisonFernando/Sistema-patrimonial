using Dapper;
using model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EquipamentoDAL
    {
        ConexaoDB mConn = new ConexaoDB();
        string sql;
        MySqlCommand cmd;
        public string conec = "Persist Security Info = False; server=syspatrimonial.mysql.dbaas.com.br;database=syspatrimonial;uid=syspatrimonial;pwd=Alison17@;";

        public void InserirEquipamento(Equipamento equipamento, string emailUsuarioLogado)
        {
            string ativo = "0";
            if (equipamento.Ativo_inativo)
            {
                ativo = "1";
            }

            sql = "INSERT INTO tb_equipamentos(Nome_equipamento, Ativo_inativo, Valor, Descricao, Etiqueta_identificacao, id_marca) VALUES " +
                    "(@Nome, @Ativo_inativo, @Valor, @Descricao, @Etiqueta, @id_marca)";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());
            
            cmd.Parameters.AddWithValue("@nome", equipamento.Nome);
            cmd.Parameters.AddWithValue("@ativo_inativo", ativo);
            cmd.Parameters.AddWithValue("@valor", equipamento.Valor);
            cmd.Parameters.AddWithValue("@descricao", equipamento.Descricao);
            cmd.Parameters.AddWithValue("@etiqueta", equipamento.Etiqueta);
            cmd.Parameters.AddWithValue("@id_marca", equipamento.id_marca);

            cmd.ExecuteNonQuery();
            mConn.FecharConexao();

            // Inserir o registro de log na tabela tb_logs
            DateTime dataHoraAcao = DateTime.Now;
            string tipoOperacao = "cadastro de equipamento"; // Defina o tipo de operação conforme necessário

            sql = "INSERT INTO tb_logs(EmailUsuario, DataHoraAcao, TipoOperacao) VALUES (@EmailUsuario, @DataHoraAcao, @TipoOperacao)";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@EmailUsuario", emailUsuarioLogado);
            cmd.Parameters.AddWithValue("@DataHoraAcao", dataHoraAcao);
            cmd.Parameters.AddWithValue("@TipoOperacao", tipoOperacao);

            cmd.ExecuteNonQuery();
            mConn.FecharConexao();
        }
        public bool VerificarEtiqueta(String etiquetaEquip)
        {
            bool etiquetaExists = false;
            string sql = "SELECT COUNT(*) FROM tb_equipamentos WHERE Etiqueta_identificacao = @etiqueta";

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@etiqueta", etiquetaEquip);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        etiquetaExists = true;
                    }
                }
            }
            return etiquetaExists;
        }


        //Escolher os equipamentos disponíveis para passar para o colaborador
        public List<Equipamento> GetEquipamentosDisponiveis()
        {

            using (IDbConnection dbConnection = new MySqlConnection(conec))
            {
                dbConnection.Open();
                return dbConnection.Query<Equipamento>("SELECT ID_equipamento, Nome_equipamento Nome, Ativo_inativo Ativo_inativo, Valor Valor, Descricao, Etiqueta_identificacao Etiqueta, id_colaborador id_colaborador, id_marca id_marca FROM tb_equipamentos WHERE id_colaborador IS NULL").ToList();
            }
        }
        public List<Equipamento> GetEquipamentos()
        {

            using (IDbConnection dbConnection = new MySqlConnection(conec))
            {
                dbConnection.Open();
                return dbConnection.Query<Equipamento>("SELECT ID_equipamento, Nome_equipamento Nome, Ativo_inativo Ativo_inativo, Valor, Descricao, Etiqueta_identificacao Etiqueta, id_colaborador id_colaborador, id_marca id_marca FROM tb_equipamentos").ToList();
            }
        }

        public void UpdateEquipamentos(Equipamento equipamento, string emailUsuarioLogado)
        {
            using (IDbConnection dbConnection = new MySqlConnection(conec))
            {
                dbConnection.Open();
                string query = "UPDATE tb_equipamentos SET Nome_Equipamento = @Nome, Valor = @Valor, Descricao = @Descricao  WHERE ID_equipamento = @ID_equipamento";
                dbConnection.Execute(query, equipamento);


                //Inserção de log
                DateTime dataHoraAcao = DateTime.Now;
                string tipoOperacao = "atualização de equipamento"; // Defina o tipo de operação conforme necessário

                sql = "INSERT INTO tb_logs(EmailUsuario, DataHoraAcao, TipoOperacao) VALUES (@EmailUsuario, @DataHoraAcao, @TipoOperacao)";
                cmd = new MySqlCommand(sql, mConn.AbrirConexao());

                cmd.Parameters.AddWithValue("@EmailUsuario", emailUsuarioLogado);
                cmd.Parameters.AddWithValue("@DataHoraAcao", dataHoraAcao);
                cmd.Parameters.AddWithValue("@TipoOperacao", tipoOperacao);

                cmd.ExecuteNonQuery();
                mConn.FecharConexao();
            }
        }
        public void DeleteEquipamento(int ID_equipamento, string emailUsuarioLogado)
        {
            using (IDbConnection dbConnection = new MySqlConnection(conec))
            {
                dbConnection.Open();
                string query = "DELETE FROM tb_equipamentos WHERE ID_equipamento = @ID_equipamento";
                dbConnection.Execute(query, new { ID_equipamento });


                //Inserção de log
                DateTime dataHoraAcao = DateTime.Now;
                string tipoOperacao = "delete de equipamento"; // Defina o tipo de operação conforme necessário

                sql = "INSERT INTO tb_logs(EmailUsuario, DataHoraAcao, TipoOperacao) VALUES (@EmailUsuario, @DataHoraAcao, @TipoOperacao)";
                cmd = new MySqlCommand(sql, mConn.AbrirConexao());

                cmd.Parameters.AddWithValue("@EmailUsuario", emailUsuarioLogado);
                cmd.Parameters.AddWithValue("@DataHoraAcao", dataHoraAcao);
                cmd.Parameters.AddWithValue("@TipoOperacao", tipoOperacao);

                cmd.ExecuteNonQuery();
                mConn.FecharConexao();
            }
        }
        public List<Equipamento> GetEquipamentosRelatorio()
        {

            using (IDbConnection dbConnection = new MySqlConnection(conec))
            {
                dbConnection.Open();
                return dbConnection.Query<Equipamento>("SELECT Nome_equipamento FROM tb_equipamentos").ToList();
            }
        }

        public List<Equipamento> ObterEquipamentosPorColaborador(int idColaborador)
        {
            List<Equipamento> equipamentos = new List<Equipamento>();
            using (MySqlConnection connection = new MySqlConnection(conec))
            {
                connection.Open();
                string query = "SELECT * FROM tb_equipamentos WHERE id_colaborador = @idColaborador";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@idColaborador", idColaborador);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Equipamento equipamento = new Equipamento
                        {
                            ID_equipamento = Convert.ToInt32(reader["ID_equipamento"]),
                            Nome = reader["Nome_equipamento"].ToString(),
                            Descricao = reader["Descricao"].ToString(),
                            Etiqueta = reader["Etiqueta_identificacao"].ToString(),                            
                            // Adicione outros campos conforme necessário
                        };
                        equipamentos.Add(equipamento);
                    }
                }
            }
            return equipamentos;
        }

    }
}