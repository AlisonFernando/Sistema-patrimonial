using DAL;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ColaboradorBLL
    {
        public string CadColab(Colaborador colaborador, string emailUsuarioLogado)
        {
            ColaboradorDAL colaboradorDAL = new ColaboradorDAL();
            colaboradorDAL.InserirColaborador(colaborador, emailUsuarioLogado);
            return "Sucesso";
        }

        public string VerificarNome(string verifnome)
        {
            ColaboradorDAL colaboradorDAL = new ColaboradorDAL();
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
            ColaboradorDAL colaboradorDAL = new ColaboradorDAL();
            colaboradorDAL.AssociarEquipamentosAoColaborador(idColaborador, equipamentosSelecionados);
            return "Sucesso";
        }

        public int ObterIdColaboradorPorNome(string nomeColaborador)
        {
            ColaboradorDAL colaboradorDAL = new ColaboradorDAL();
            return colaboradorDAL.ObterIdColaboradorPorNome(nomeColaborador);
        }
        public List<Colaborador> GetColaboradoresAtivosComSetor()
        {
            ColaboradorDAL colaboradorDAL = new ColaboradorDAL();
            return colaboradorDAL.GetColaboradoresAtivosComSetor();
        }

    }
}
