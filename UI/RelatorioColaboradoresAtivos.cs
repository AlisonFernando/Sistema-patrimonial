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

                // Adicione uma linha separadora
                doc.Add(new Chunk("\n"));

                // Obtém os dados dos colaboradores ativos com o nome do setor
                ColaboradorBLL colaboradorBLL = new ColaboradorBLL();
                List<Colaborador> colaboradores = colaboradorBLL.GetColaboradoresAtivosComSetor().OrderBy(colaborador => colaborador.NomeColaborador).ToList();

                // Crie uma tabela para exibir os dados dos colaboradores
                PdfPTable table = new PdfPTable(4); // 4 colunas para Nome, Email, Telefone e Setor
                table.WidthPercentage = 100; // A largura da tabela é 100% do tamanho da página

                // Cabeçalho da tabela
                iTextSharp.text.Font headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                BaseColor headerBackgroundColor = new BaseColor(63, 96, 35); // Cor #Verde Scot

                PdfPCell headerCellNome = new PdfPCell(new Phrase("Nome", headerFont));
                headerCellNome.BackgroundColor = headerBackgroundColor;
                headerCellNome.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(headerCellNome);

                PdfPCell headerCellEmail = new PdfPCell(new Phrase("Email", headerFont));
                headerCellEmail.BackgroundColor = headerBackgroundColor;
                headerCellEmail.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(headerCellEmail);

                PdfPCell headerCellTelefone = new PdfPCell(new Phrase("Telefone", headerFont));
                headerCellTelefone.BackgroundColor = headerBackgroundColor;
                headerCellTelefone.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(headerCellTelefone);

                PdfPCell headerCellSetor = new PdfPCell(new Phrase("Setor", headerFont));
                headerCellSetor.BackgroundColor = headerBackgroundColor;
                headerCellSetor.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(headerCellSetor);

                // Dados dos colaboradores
                iTextSharp.text.Font dataFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12);

                BaseColor rowColor1 = new BaseColor(238, 238, 238); // Cor #EEEEEE
                BaseColor rowColor2 = BaseColor.WHITE; // Cor #FFF
                bool alternateRowColor = false;

                foreach (Colaborador colaborador in colaboradores)
                {
                    PdfPCell cellNome = new PdfPCell(new Phrase(colaborador.NomeColaborador, dataFont));
                    cellNome.BackgroundColor = alternateRowColor ? rowColor1 : rowColor2;
                    cellNome.HorizontalAlignment = Element.ALIGN_LEFT;
                    table.AddCell(cellNome);

                    PdfPCell cellEmail = new PdfPCell(new Phrase(colaborador.EmailColaborador, dataFont));
                    cellEmail.BackgroundColor = alternateRowColor ? rowColor1 : rowColor2;
                    cellEmail.HorizontalAlignment = Element.ALIGN_LEFT;
                    table.AddCell(cellEmail);

                    PdfPCell cellTelefone = new PdfPCell(new Phrase(colaborador.TelefoneColaborador, dataFont));
                    cellTelefone.BackgroundColor = alternateRowColor ? rowColor1 : rowColor2;
                    cellTelefone.HorizontalAlignment = Element.ALIGN_LEFT;
                    table.AddCell(cellTelefone);

                    PdfPCell cellSetor = new PdfPCell(new Phrase(colaborador.SetorNome, dataFont));
                    cellSetor.BackgroundColor = alternateRowColor ? rowColor1 : rowColor2;
                    cellSetor.HorizontalAlignment = Element.ALIGN_LEFT;
                    table.AddCell(cellSetor);

                    alternateRowColor = !alternateRowColor;
                }
                // Adicione espaço em branco entre a tabela e a imagem
                doc.Add(new Chunk("\n"));
                doc.Add(new Chunk("\n"));
                doc.Add(new Chunk("\n"));
                doc.Add(new Chunk("\n"));
                doc.Add(new Chunk("\n"));
                // Adicione a tabela ao documento
                doc.Add(table);

                // Adicione a imagem centralizada
                string imageUrl = "https://www.scotconsultoria.com.br/img/relatorio_sys.png";
                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(new Uri(imageUrl));
                image.Alignment = Element.ALIGN_CENTER;
                doc.Add(image);

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
