using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.IO;
using System.Diagnostics;
using PdfSharp.Drawing.Layout;
using MigraDoc.DocumentObjectModel;
using iTextSharp.text.pdf;
using iTextSharp.text;
using BLL;
using model;

namespace UI

{
    public partial class RelatorioEquipamentoPreco : Form
    {
        public RelatorioEquipamentoPreco()
        {
            InitializeComponent();

        }

        public EquipamentoBLL equipamentoBLL = new EquipamentoBLL();
        private string caminhoDestino = "" +
            "";
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
                iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("Relatório de Equipamentos", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                // Adicione uma linha separadora
                doc.Add(new Chunk("\n"));

                // Obtém os dados dos equipamentos
                List<Equipamento> equipamentos = equipamentoBLL.GetEquipamentos();

                // Crie uma tabela para exibir os dados dos equipamentos
                PdfPTable table = new PdfPTable(4); // 4 colunas para ID, Nome, Valor e Etiqueta
                table.WidthPercentage = 100; // A largura da tabela é 100% do tamanho da página

                // Cabeçalho da tabela
                iTextSharp.text.Font headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);
                table.AddCell(new PdfPCell(new Phrase("ID", headerFont)));
                table.AddCell(new PdfPCell(new Phrase("Nome", headerFont)));
                table.AddCell(new PdfPCell(new Phrase("Valor", headerFont)));
                table.AddCell(new PdfPCell(new Phrase("Etiqueta", headerFont)));

                // Dados dos equipamentos
                iTextSharp.text.Font dataFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10);
                decimal valorTotal = 0;

                foreach (Equipamento equipamento in equipamentos)
                {
                    table.AddCell(new PdfPCell(new Phrase(equipamento.ID_equipamento.ToString(), dataFont)));
                    table.AddCell(new PdfPCell(new Phrase(equipamento.Nome, dataFont)));
                    table.AddCell(new PdfPCell(new Phrase(equipamento.Valor.ToString(), dataFont)));
                    table.AddCell(new PdfPCell(new Phrase(equipamento.Etiqueta, dataFont)));

                    valorTotal += decimal.TryParse(equipamento.Valor, out decimal valor) ? valor : 0;
                }

                // Adicione a tabela ao documento
                doc.Add(table);

                // Adicione uma linha separadora
                doc.Add(new Chunk("\n"));

                // Adicione o valor total dos equipamentos
                iTextSharp.text.Paragraph totalParagraph = new iTextSharp.text.Paragraph($"Valor total dos equipamentos: {valorTotal.ToString("C")}");
                totalParagraph.Alignment = Element.ALIGN_RIGHT;
                doc.Add(totalParagraph);

                // Fecha o documento
                doc.Close();

                MessageBox.Show("Relatório em PDF gerado com sucesso e salvo em: " + caminhoDestino, "PDF Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
