using BLL;
using iTextSharp.text.pdf;
using iTextSharp.text;
using model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class RelatorioColaboradoresAtivos : Form
    {
        private string caminhoDestino;
        public RelatorioColaboradoresAtivos()
        {
            InitializeComponent();
        }

        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(caminhoDestino))
                {
                    MessageBox.Show("Por favor, escolha um local de salvamento.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Cria um documento PDF usando o iTextSharp
                iTextSharp.text.Document doc = new iTextSharp.text.Document();

                // Cria um objeto PdfWriter para escrever no arquivo PDF
                PdfWriter.GetInstance(doc, new FileStream(caminhoDestino, FileMode.Create));

                // Abre o documento para escrita
                doc.Open();

                iTextSharp.text.Font titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("Relatório de Colaboradores Ativos", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                // Adicione uma linha separadora
                doc.Add(new Chunk("\n"));

                // Obtém os dados dos colaboradores ativos com o nome do setor
                ColaboradorBLL colaboradorBLL = new ColaboradorBLL();
                List<Colaborador> colaboradores = colaboradorBLL.GetColaboradoresAtivosComSetor().OrderBy(colaborador => colaborador.NomeColaborador).ToList();

                // Crie uma tabela para exibir os dados dos colaboradores
                PdfPTable table = new PdfPTable(4); // 4 colunas para Nome, Email, Telefone e Setor
                table.WidthPercentage = 100; // A largura da tabela é 100% do tamanho da página

                // Cabeçalho da tabela
                iTextSharp.text.Font headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);
                table.AddCell(new PdfPCell(new Phrase("Nome", headerFont)));
                table.AddCell(new PdfPCell(new Phrase("Email", headerFont)));
                table.AddCell(new PdfPCell(new Phrase("Telefone", headerFont)));
                table.AddCell(new PdfPCell(new Phrase("Setor", headerFont)));

                // Dados dos colaboradores
                iTextSharp.text.Font dataFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10);

                foreach (Colaborador colaborador in colaboradores)
                {
                    table.AddCell(new PdfPCell(new Phrase(colaborador.NomeColaborador, dataFont)));
                    table.AddCell(new PdfPCell(new Phrase(colaborador.EmailColaborador, dataFont)));
                    table.AddCell(new PdfPCell(new Phrase(colaborador.TelefoneColaborador, dataFont)));
                    table.AddCell(new PdfPCell(new Phrase(colaborador.SetorNome, dataFont))); // Use a propriedade SetorNome para obter o nome do setor
                }

                // Adicione a tabela ao documento
                doc.Add(table);

                // Fecha o documento
                doc.Close();

                MessageBox.Show("Relatório de Colaboradores Ativos em PDF gerado com sucesso e salvo em: " + caminhoDestino, "PDF Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Captura erros
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCaminho_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Escolher o local de salvamento";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtenha o caminho escolhido pelo usuário
                caminhoDestino = saveFileDialog.FileName;

                // Exiba o caminho no TextBox txtDestino
                txtDestino.Text = caminhoDestino;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
