using model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

            sql = "INSERT INTO tb_equipamentos(Nome_equipamento, Descricao, Valor, Etiqueta_identificacao) VALUES (@Nome, @Descricao, @Valor, @Etiqueta) ";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@nome", equipamento.Nome);
            cmd.Parameters.AddWithValue("@descricao", equipamento.Descricao);
            cmd.Parameters.AddWithValue("@valor", equipamento.Valor);
            cmd.Parameters.AddWithValue("@etiqueta", equipamento.Etiqueta);

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
    }
}
