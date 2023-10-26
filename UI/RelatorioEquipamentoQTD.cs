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
    public partial class TelaRelatorioEquipsQTD : Form
    {
        public TelaRelatorioEquipsQTD()
        {
            InitializeComponent();
        }
        private string caminhoDestino;
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
                iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("Relatório da quantidade de Equipamentos", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                // Adicione uma linha separadora
                doc.Add(new Chunk("\n"));

                // Obtém os dados dos equipamentos
                EquipamentoBLL equipamentoBLL = new EquipamentoBLL();
                List<Equipamento> equipamentos = equipamentoBLL.GetEquipamentos().OrderBy(equipamento => equipamento.nome).ToList();

                // Crie uma tabela para exibir os dados dos equipamentos
                PdfPTable table = new PdfPTable(3); // 3 colunas para  Nome, Valor e Etiqueta
                table.WidthPercentage = 100; // A largura da tabela é 100% do tamanho da página

                // Cabeçalho da tabela
                iTextSharp.text.Font headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);
                table.AddCell(new PdfPCell(new Phrase("Nome", headerFont)));
                table.AddCell(new PdfPCell(new Phrase("Valor", headerFont)));
                table.AddCell(new PdfPCell(new Phrase("Etiqueta", headerFont)));

                // Dados dos equipamentos
                iTextSharp.text.Font dataFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10);

                int totalEquipamentos = 0; // Variável para contar o número de equipamentos

                foreach (Equipamento equipamento in equipamentos)
                {
                    table.AddCell(new PdfPCell(new Phrase(equipamento.Nome, dataFont)));
                    table.AddCell(new PdfPCell(new Phrase(equipamento.Valor.ToString(), dataFont)));
                    table.AddCell(new PdfPCell(new Phrase(equipamento.Etiqueta, dataFont)));

                    totalEquipamentos++; // Incrementa a contagem a cada equipamento listado
                }

                // Adicione a tabela ao documento
                doc.Add(table);

                // Adicione uma linha separadora
                doc.Add(new Chunk("\n"));

                // Adicione o total de equipamentos listados
                iTextSharp.text.Paragraph totalParagraph = new iTextSharp.text.Paragraph($"Total de Equipamentos Listados: {totalEquipamentos}");
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
