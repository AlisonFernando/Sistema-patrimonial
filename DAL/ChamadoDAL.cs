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

        public void CadastrarChamado(Chamado chamado)
        {
            sql = "INSERT INTO tb_chamado(Data_hora_do_chamado, descricao, id_usuario, id_status) VALUES " +
                    "(@DataHora, @Descricao, @id_usuario, @id_status)";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("DataHora", chamado.DataHora);
            cmd.Parameters.AddWithValue("@descricao", chamado.Descricao);
            cmd.Parameters.AddWithValue("@id_usuario", chamado.id_usuario);
            cmd.Parameters.AddWithValue("id_status", chamado.id_status);
            cmd.Parameters.AddWithValue("@equipamento_id", chamado.id_equipamento);
            


            cmd.ExecuteNonQuery();
            mConn.FecharConexao();
        }

        public DataTable EscolherEtiqueta()
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tb_equipamentos WHERE Ativo_inativo = @Ativo_inativo";
                using (MySqlConnection connection = mConn.AbrirConexao())
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Ativo_inativo", 1);

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
