using DAL;
using model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ColaboradorBLL
    {
        ColaboradorDAL colaboradorDAL = new ColaboradorDAL();
        public string CadColab(Colaborador colaborador, string emailUsuarioLogado)
        {
            ColaboradorDAL colaboradorDAL = new ColaboradorDAL();
            colaboradorDAL.InserirColaborador(colaborador, emailUsuarioLogado);
            return "Sucesso";
        }

        public string VerificarNome(string verifnome)
        {

            bool nomeExists = colaboradorDAL.VerificarNome(verifnome);

            if (nomeExists)
            {
                return "nome existente";
            }
            else
            {
                return "nome não existe";
            }
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public string AssociarEquipamentosAoColaborador(int idColaborador, List<int> equipamentosSelecionados)
        {
            colaboradorDAL.AssociarEquipamentosAoColaborador(idColaborador, equipamentosSelecionados);
            return "Sucesso";
        }

        public int ObterIdColaboradorPorNome(string nomeColaborador)
        {
            return colaboradorDAL.ObterIdColaboradorPorNome(nomeColaborador);
        }
        public List<Colaborador> GetColaboradoresAtivosComSetor()
        {
            return colaboradorDAL.GetColaboradoresAtivosComSetor();
        }
        public void DesativarColaborador(int ID_Colab)
        {
            colaboradorDAL.DesativarColaborador(ID_Colab);
        }
        public Colaborador ObterColaboradorPorID(int idColaborador)
        {

            return colaboradorDAL.ObterColaboradorPorID(idColaborador);
        }
        public DataTable CarregarColaborador()
        {
            DataTable dt = colaboradorDAL.ConsultarColaborador();
            return dt;
        }

    }
}
