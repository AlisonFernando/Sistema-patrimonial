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
            string senhaNaoCriptografada = colaborador.SenhaColaborador;
            string senhaCriptografada = HashPassword(senhaNaoCriptografada);
            colaborador.SenhaHash = senhaCriptografada;

            sql = "INSERT INTO tb_colaborador(Nome, Email, Agenda, Telefone, Ativo_inativo, Senha, id_setor) VALUES " +
                  "(@NomeColaborador, @EmailColaborador, @AgendaColaborador, @TelefoneColaborador, @Ativo_inativo, @senha_colaborador, @id_setor) ";
            cmd = new MySqlCommand(sql, mConn.AbrirConexao());

            cmd.Parameters.AddWithValue("@nomeColaborador", colaborador.NomeColaborador);
            cmd.Parameters.AddWithValue("@emailColaborador", colaborador.EmailColaborador);
            cmd.Parameters.AddWithValue("@agendaColaborador", colaborador.AgendaColaborador);
            cmd.Parameters.AddWithValue("@telefoneColaborador", colaborador.TelefoneColaborador);
            cmd.Parameters.AddWithValue("@ativo_inativo", ativo);
            cmd.Parameters.AddWithValue("@senha_colaborador", colaborador.SenhaHash);
            cmd.Parameters.AddWithValue("@id_setor", colaborador.id_setor);

            cmd.ExecuteNonQuery();
            mConn.FecharConexao();
        }
        private string HashPassword(string password)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);
            return hashedPassword;
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
        public string ObterNomeColaboradorPorId(string idcolaborador)
        {
            string nomeColaborador = string.Empty;

            string sql = "SELECT Nome_colaborador FROM tb_colaborador WHERE ID_colaborador = @id";
            using (MySqlConnection connection = mConn.AbrirConexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id", idcolaborador);
                    nomeColaborador = cmd.ExecuteScalar() as string;
                }
            }
            return nomeColaborador;
        }
    }
}
