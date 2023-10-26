using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using model;

namespace UI
{
    public partial class RelatorioMasterDetail : Form
    {
        public RelatorioMasterDetail()
        {
            InitializeComponent();
        }
        private string caminhoDestino;
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("Relatório de equipamentos disponíveis", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                // Adicione uma linha separadora
                doc.Add(new Chunk("\n"));

                // Obtém os dados dos equipamentos
                EquipamentoBLL equipamentoBLL = new EquipamentoBLL();
                List<Equipamento> equipamentos = equipamentoBLL.GetEquipamentosDisponiveis().OrderBy(equipamento => equipamento.nome).ToList();

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
                iTextSharp.text.Paragraph totalParagraph = new iTextSharp.text.Paragraph($"Total de equipamentos disponíveis: {totalEquipamentos}");
                totalParagraph.Alignment = Element.ALIGN_RIGHT;
                doc.Add(totalParagraph);








                iTextSharp.text.Font titleFont2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Paragraph title2 = new iTextSharp.text.Paragraph("Relatório de equipamentos em manutenção", titleFont);
                title2.Alignment = Element.ALIGN_CENTER;
                doc.Add(title2);

                // Adicione uma linha separadora
                doc.Add(new Chunk("\n"));

                // Obtém os dados dos equipamentos
                ManutencaoBLL manutencaoBLL= new ManutencaoBLL();
                List<Manutencao> manutencao = manutencaoBLL.GetManutencoes().OrderBy(equipamento => equipamento.NomeEquipamento).ToList();

                // Crie uma tabela para exibir os dados dos equipamentos
                PdfPTable table2 = new PdfPTable(3); // 3 colunas para  Nome, Valor e Etiqueta
                table.WidthPercentage = 100; // A largura da tabela é 100% do tamanho da página

                // Cabeçalho da tabela
                iTextSharp.text.Font headerFont2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);
                table2.AddCell(new PdfPCell(new Phrase("Nome", headerFont)));
                table2.AddCell(new PdfPCell(new Phrase("Descrição", headerFont)));
                table2.AddCell(new PdfPCell(new Phrase("Técnico", headerFont)));

                // Dados dos equipamentos
                iTextSharp.text.Font dataFont2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10);

                int totalEquipamentos2 = 0; // Variável para contar o número de equipamentos

                foreach (Manutencao manutencao1 in manutencao)
                {
                    table2.AddCell(new PdfPCell(new Phrase(manutencao1.NomeEquipamento, dataFont)));
                    table2.AddCell(new PdfPCell(new Phrase(manutencao1.Descricao.ToString(), dataFont)));
                    table2.AddCell(new PdfPCell(new Phrase(manutencao1.NomeUsuario, dataFont)));

                    totalEquipamentos2++; // Incrementa a contagem a cada equipamento listado
                }

                // Adicione a tabela ao documento
                doc.Add(table2);

                // Adicione uma linha separadora
                doc.Add(new Chunk("\n"));

                // Adicione o total de equipamentos listados
                iTextSharp.text.Paragraph totalParagraph2 = new iTextSharp.text.Paragraph($"Total de equipamentos em manutenção: {totalEquipamentos2}");
                totalParagraph2.Alignment = Element.ALIGN_RIGHT;
                doc.Add(totalParagraph2);

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
    }
}
