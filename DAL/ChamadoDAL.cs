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
    public class ChamadoDAL
    {
        ConexaoDB mConn = new ConexaoDB();
        string sql;
        MySqlCommand cmd;

        public void CadastrarChamado(Chamado chamado, string emailUsuarioLogado)
        {
            try
            {
                string sqlChamado = "INSERT INTO tb_chamado(Data_hora_do_chamado, descricao, id_usuario, id_status, id_equipamento, id_colaborador) " +
                                    "VALUES (@DataHora, @Descricao, @id_usuario, @id_status, @id_equipamento, @id_colaborador)";

                using (MySqlConnection connection = mConn.AbrirConexao())
                {
                    using (MySqlCommand cmdChamado = new MySqlCommand(sqlChamado, connection))
                    {
                        cmdChamado.Parameters.AddWithValue("@DataHora", chamado.DataHora);
                        cmdChamado.Parameters.AddWithValue("@Descricao", chamado.Descricao);
                        cmdChamado.Parameters.AddWithValue("@id_usuario", chamado.id_usuario);
                        cmdChamado.Parameters.AddWithValue("@id_status", chamado.id_status);
                        cmdChamado.Parameters.AddWithValue("@id_equipamento", chamado.id_equipamento);
                        cmdChamado.Parameters.AddWithValue("@id_colaborador", chamado.id_colaborador);
                            

                        cmdChamado.ExecuteNonQuery();
                    }

                    // Após inserir o chamado, recuperar o id_chamado gerado
                    UInt64 idChamadoGerado; // Alteração aqui
                    string selectLastIdSql = "SELECT LAST_INSERT_ID()";
                    MySqlCommand selectLastIdCommand = new MySqlCommand(selectLastIdSql, connection);
                    idChamadoGerado = (UInt64)selectLastIdCommand.ExecuteScalar(); // Alteração aqui

                    // Criar uma instância de 'manutencao' e preencher com os valores do 'chamado'
                    Manutencao manutencao = new Manutencao();

                    manutencao.DataChamado = chamado.DataHora;
                    manutencao.Descricao = chamado.Descricao;
                    manutencao.id_usuario = chamado.id_usuario;
                    manutencao.id_status = chamado.id_status;
                    manutencao.id_equipamento = chamado.id_equipamento;
                    manutencao.id_colaborador = chamado.id_colaborador;

                    // Agora, insira na tabela tb_manutencao usando o id_chamado
                    string sqlManutencao = "INSERT INTO tb_manutencao(id_chamado, data_hora_do_chamado, descricao, id_usuario, id_status, id_equipamento, id_colaborador) " +
                                           "VALUES (@idChamado, @DataHora, @Descricao, @id_usuario, @id_status, @id_equipamento, @id_colaborador)";

                    using (MySqlCommand cmdManutencao = new MySqlCommand(sqlManutencao, connection))
                    {
                        cmdManutencao.Parameters.AddWithValue("@idChamado", idChamadoGerado);
                        cmdManutencao.Parameters.AddWithValue("@DataHora", manutencao.DataChamado);
                        cmdManutencao.Parameters.AddWithValue("@Descricao", manutencao.Descricao);
                        cmdManutencao.Parameters.AddWithValue("@id_usuario", manutencao.id_usuario);
                        cmdManutencao.Parameters.AddWithValue("@id_status", manutencao.id_status);
                        cmdManutencao.Parameters.AddWithValue("@id_equipamento", manutencao.id_equipamento);
                        cmdManutencao.Parameters.AddWithValue("@id_colaborador", manutencao.id_colaborador);

                        cmdManutencao.ExecuteNonQuery();
                    }

                    // Após inserir na tabela tb_manutencao, atualize a disponibilidade da etiqueta
                    AtualizarDisponibilidadeEtiqueta(connection, chamado.id_equipamento, false);
                }
                // Inserir o registro de log na tabela tb_logs
                DateTime dataHoraAcao = DateTime.Now;
                string tipoOperacao = "abertura de chamado"; // Defina o tipo de operação conforme necessário

                sql = "INSERT INTO tb_logs(EmailUsuario, DataHoraAcao, TipoOperacao) VALUES (@EmailUsuario, @DataHoraAcao, @TipoOperacao)";
                cmd = new MySqlCommand(sql, mConn.AbrirConexao());

                cmd.Parameters.AddWithValue("@EmailUsuario", emailUsuarioLogado);
                cmd.Parameters.AddWithValue("@DataHoraAcao", dataHoraAcao);
                cmd.Parameters.AddWithValue("@TipoOperacao", tipoOperacao);

                cmd.ExecuteNonQuery();
                mConn.FecharConexao();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void AtualizarDisponibilidadeEtiqueta(MySqlConnection connection, string idEquipamento, bool ativo_inativo)
        {
            string sql = "UPDATE tb_equipamentos SET Ativo_inativo = @Ativo_inativo WHERE ID_equipamento = @ID_equipamento";

            using (MySqlCommand cmd = new MySqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@Ativo_inativo", ativo_inativo ? 1 : 0);
                cmd.Parameters.AddWithValue("@ID_equipamento", idEquipamento);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable EscolherEtiquetasDisponiveis()
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tb_equipamentos WHERE Ativo_inativo = 1";
                using (MySqlConnection connection = mConn.AbrirConexao())
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable EscolherNomeUsuario()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM tb_usuario";

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

        public (string NomeEquipamento, string NomeColaborador) BuscarNomeEquipamento(int idEquipamento)
        {
            try
            {
                string sql = @"
            SELECT 
                e.Nome_equipamento AS NomeEquipamento,
                c.Nome AS NomeColaborador
            FROM tb_equipamentos e
            LEFT JOIN tb_colaborador c ON e.id_colaborador = c.id_colaborador
            WHERE e.ID_equipamento = @ID_equipamento";

                using (MySqlConnection connection = mConn.AbrirConexao())
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID_equipamento", idEquipamento);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Obtém o nome do equipamento e do colaborador
                                string nomeEquipamento = reader["NomeEquipamento"].ToString();
                                string nomeColaborador = reader["NomeColaborador"].ToString();

                                // Retorna uma tupla com os nomes
                                return (nomeEquipamento, nomeColaborador);
                            }
                        }
                    }
                }

                // Retorna uma tupla com strings vazias caso não seja encontrado.
                return (string.Empty, string.Empty);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable BuscarStatusChamado()
        {
            DataTable dt = new DataTable();

            try
            {
                // Modifique a consulta SQL para selecionar apenas os status com IDs 2 e 3.
                string sql = "SELECT * FROM tb_status WHERE id_status IN (2, 3)";

                using (MySqlConnection connection = mConn.AbrirConexao())
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
