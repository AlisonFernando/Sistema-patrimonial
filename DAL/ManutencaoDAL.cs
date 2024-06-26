﻿using model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManutencaoDAL
    {
        ConexaoDB mConn = new ConexaoDB();
        string sql;
        MySqlCommand cmd;

        public List<Manutencao> GetManutencoes()
        {
            List<Manutencao> manutencaoList = new List<Manutencao>();

            using (MySqlConnection connection = mConn.AbrirConexao())
            {

                string query = "SELECT " +
                                "m.id_chamado, " +
                                "m.id_equipamento, " +
                                "m.Data_hora_do_chamado AS DataChamado, " +
                                "m.descricao, " +
                                "u.Nome AS NomeUsuario, " +
                                "m.id_status, " +
                                "e.nome_equipamento AS NomeEquipamento, " +
                                "c.Nome AS NomeColaborador, " +
                                "m.id_colaborador " +  // Adicionei esta linha
                                "FROM tb_manutencao AS m " +
                                "JOIN tb_equipamentos AS e ON m.id_equipamento = e.id_equipamento " +
                                "JOIN tb_usuario AS u ON m.id_usuario = u.id_usuario " +
                                "LEFT JOIN tb_colaborador AS c ON m.id_colaborador = c.id_colaborador";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Manutencao manutencao = new Manutencao();
                            manutencao.id_chamado = (int)reader["id_chamado"];
                            manutencao.DataChamado = (DateTime)reader["DataChamado"];
                            manutencao.Descricao = reader["descricao"].ToString();
                            manutencao.NomeUsuario = reader["NomeUsuario"].ToString(); // Nome do usuário
                            manutencao.id_status = (int)reader["id_status"]; // Andamento do chamado
                            manutencao.NomeEquipamento = reader["NomeEquipamento"].ToString();
                            manutencao.id_equipamento = reader["id_equipamento"].ToString();
                            manutencao.NomeColaborador = reader["NomeColaborador"].ToString();
                            manutencao.id_colaborador = reader["id_colaborador"] == DBNull.Value ? 0 : Convert.ToInt32(reader["id_colaborador"]);

                            manutencaoList.Add(manutencao);
                        }
                    }
                }
            }
            return manutencaoList;
        }

        public int ObterIdStatusEquipamento(int idEquipamento)
        {
            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                connection.Open();

                string query = "SELECT id_status FROM tb_manutencao WHERE id_equipamento = @idEquipamento";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idEquipamento", idEquipamento);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Convert.ToInt32(reader["id_status"]);
                        }
                    }
                }
            }
            return 0; // Se não encontrar, retorne um valor padrão (pode ajustar conforme necessário)
        }
    }
}
