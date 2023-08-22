using model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

        public void InserirEquipamento(Equipamento equipamento)
        {
            string ativo = "0";
            if (equipamento.Ativo_inativo)
            {
                ativo = "1";
            }

            sql = "INSERT INTO tb_equipamentos(Nome_equipamento, Ativo_inativo, Valor, Descricao, Etiqueta_identificacao, id_colaborador, id_marca) VALUES " +
                    "(@Nome, @Descricao, @Ativo_inativo, @Valor, @Etiqueta, @colaborador_id, @marca_id)";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@nome", equipamento.Nome);
            cmd.Parameters.AddWithValue("@descricao", equipamento.Descricao);
            cmd.Parameters.AddWithValue("@ativo_inativo", ativo);
            cmd.Parameters.AddWithValue("@valor", equipamento.Valor);
            cmd.Parameters.AddWithValue("@etiqueta", equipamento.Etiqueta);
            cmd.Parameters.AddWithValue("@colaborador_id", equipamento.colaborador_id);
            cmd.Parameters.AddWithValue("@marca_id", equipamento.marca_id);

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


        //Escolher os equipamentos ativos no banco de dados para cadastrar no colaborador
        public DataTable EscolherEquipamentos()
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
        public string ObterNomeEquipamentoPorId(string idEquipamento)
        {
            string nomeEquipamento = string.Empty;

            string sql = "SELECT Nome_equipamento FROM tb_equipamentos WHERE ID_equipamento = @id";
            using (MySqlConnection connection = mConn.AbrirConexao())
            using (MySqlCommand cmd = new MySqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@id", idEquipamento);
                nomeEquipamento = cmd.ExecuteScalar() as string;
            }
            return nomeEquipamento;
        }
    }
}