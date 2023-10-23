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
    public class ManutencaoDAL
    {
        public string conec = "Persist Security Info = False; server=syspatrimonial.mysql.dbaas.com.br;database=syspatrimonial;uid=syspatrimonial;pwd=Alison17@;";

        ConexaoDB mConn = new ConexaoDB();
        string sql;
        MySqlCommand cmd;

        public List<Manutencao> GetManutencoes()
        {
            List<Manutencao> manutencaoList = new List<Manutencao>();

            using (MySqlConnection connection = new MySqlConnection(conec))
            {
                connection.Open();

                string query = "SELECT m.id_chamado, m.id_equipamento, m.Data_hora_do_chamado AS DataChamado, m.descricao, u.Nome AS NomeUsuario, m.id_status, e.nome_equipamento AS NomeEquipamento " +
               "FROM tb_manutencao AS m " +
               "JOIN tb_equipamentos AS e ON m.id_equipamento = e.id_equipamento " +
               "JOIN tb_usuario AS u ON m.id_usuario = u.id_usuario";




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

                            manutencaoList.Add(manutencao);
                        }
                    }
                }
            }

            return manutencaoList;
        }
    }
}
