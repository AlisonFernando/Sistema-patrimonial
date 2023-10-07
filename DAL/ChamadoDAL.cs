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
    public class ChamadoDAL
    {
        public string conec = "Persist Security Info = False; server=syspatrimonial.mysql.dbaas.com.br;database=syspatrimonial;uid=syspatrimonial;pwd=Alison17@;";

        ConexaoDB mConn = new ConexaoDB();
        string sql;
        MySqlCommand cmd;

        public void CadastrarChamado(Chamado chamado)
        {
            try
            {
                string sql = "INSERT INTO tb_chamado(Data_hora_do_chamado, descricao, id_usuario, id_status, id_equipamento) VALUES " +
                             "(@DataHora, @Descricao, @id_usuario, @id_status, @id_equipamento)";

                using (MySqlConnection connection = mConn.AbrirConexao())
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@DataHora", chamado.DataHora);
                        cmd.Parameters.AddWithValue("@Descricao", chamado.Descricao);
                        cmd.Parameters.AddWithValue("@id_usuario", chamado.id_usuario);
                        cmd.Parameters.AddWithValue("@id_status", chamado.id_status);
                        cmd.Parameters.AddWithValue("@id_equipamento", chamado.id_equipamento);

                        cmd.ExecuteNonQuery();
                    }

                    // Após inserir o chamado, atualize a disponibilidade da etiqueta
                    AtualizarDisponibilidadeEtiqueta(connection, chamado.id_equipamento, false);
                }
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

        public string BuscarNomeEquipamento(int idEquipamento)
        {
            try
            {
                string sql = "SELECT Nome_equipamento FROM tb_equipamentos WHERE ID_equipamento = @ID_equipamento";
                using (MySqlConnection connection = mConn.AbrirConexao())
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID_equipamento", idEquipamento);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return reader["Nome_equipamento"].ToString();
                            }
                        }
                    }
                }
                return string.Empty; // Retornar uma string vazia caso não seja encontrado.
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
                // Modifique a consulta SQL para selecionar todos os usuários.
                string sql = "SELECT * FROM tb_status";

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
        public List<Chamado> GetEquipsChamado()
        {

            using (IDbConnection dbConnection = new MySqlConnection(conec))
            {
                dbConnection.Open();
                return dbConnection.Query<Chamado>("SELECT id_chamado, descricao, id_usuario, id_status, id_equipamento from tb_chamado").ToList();
            }
        }

    }
}
