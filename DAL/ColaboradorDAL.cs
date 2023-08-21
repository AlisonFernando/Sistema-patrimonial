using model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ColaboradorDAL
    {
        ConexaoDB mConn = new ConexaoDB();
        string sql;
        MySqlCommand cmd;

        public void InserirColaborador(Colaborador colaborador)
        {
            string ativo = "0";
            if (colaborador.Ativo_inativo)
            {
                ativo = "1";
            }

            sql = "INSERT INTO tb_colaborador(Nome, Senha, Link_agenda, Telefone, Ativo_inativo, Email, setor_id) VALUES " +
                    "(@NomeColaborador, @SenhaColaborador, @AgendaColaborador, @TelefoneColaborador, @Ativo_inativo, @EmailColaborador, @setor_id) ";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@nomeColaborador", colaborador.NomeColaborador);
            cmd.Parameters.AddWithValue("@senhaColaborador", colaborador.SenhaColaborador);
            cmd.Parameters.AddWithValue("@agendaColaborador", colaborador.AgendaColaborador);
            cmd.Parameters.AddWithValue("@telefoneColaborador", colaborador.TelefoneColaborador);
            cmd.Parameters.AddWithValue("@ativo_inativo", ativo);
            cmd.Parameters.AddWithValue("@emailColaborador", colaborador.EmailColaborador);
            cmd.Parameters.AddWithValue("@setor_id", colaborador.setor_id);
            //cmd.Parameters.AddWithValue("equipamento_id", colaborador.equipamento_id);

            cmd.ExecuteNonQuery();
            mConn.FecharConexao();
        }

        public bool VerificarNome(String nomeColab)
        {
            bool nomeExists = false;
            string sql = "SELECT COUNT(*) FROM tb_colaborador WHERE Nome = @nomeColaborador";

            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nomeColaborador", nomeColab);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        nomeExists = true;
                    }
                }
            }
            return nomeExists;
        }
        public void SalvarEquipamentosSelecionados(List<string> idsSelecionados)
        {
            string sql = "INSERT INTO tb_colaborador (equipamento_id) VALUES (@ID_equipamento)";
            using (MySqlConnection connection = mConn.AbrirConexao()) {

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {

                    foreach (string id in idsSelecionados)
                    {
                        
                        using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@ID_equipamento", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }
}
