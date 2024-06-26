﻿using System;
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
using System.Reflection.Metadata;

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

                // Adicione um título
                iTextSharp.text.Font titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                BaseColor titleBackgroundColor = new BaseColor(63, 96, 35); // Cor #Verde Scot

                /*PdfPCell titleCell = new PdfPCell(new Phrase("Relatório de Equipamentos", titleFont));
                titleCell.BackgroundColor = titleBackgroundColor;
                titleCell.HorizontalAlignment = Element.ALIGN_CENTER;
                titleCell.Padding = 10; // Adicione o espaçamento interno*/

                PdfPTable titleTable = new PdfPTable(1);
                //titleTable.WidthPercentage = 100;
                //titleTable.AddCell(titleCell);
                //doc.Add(titleTable);

                // Adicione uma linha separadora
                doc.Add(new Chunk("\n"));

                // Obtém os dados dos equipamentos
                List<Equipamento> equipamentos = equipamentoBLL.GetEquipamentos();

                // Crie uma tabela para exibir os dados dos equipamentos
                PdfPTable table = new PdfPTable(4); // 4 colunas para ID, Nome, Valor e Etiqueta
                table.WidthPercentage = 100; // A largura da tabela é 100% do tamanho da página

                // Cabeçalho da tabela
                iTextSharp.text.Font headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                BaseColor headerBackgroundColor = new BaseColor(63, 96, 35); // Cor #Verde Scot

                PdfPCell headerCellID = new PdfPCell(new Phrase("ID", headerFont));
                headerCellID.BackgroundColor = headerBackgroundColor;
                headerCellID.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(headerCellID);

                PdfPCell headerCellNome = new PdfPCell(new Phrase("Nome", headerFont));
                headerCellNome.BackgroundColor = headerBackgroundColor;
                headerCellNome.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(headerCellNome);

                PdfPCell headerCellValor = new PdfPCell(new Phrase("Valor", headerFont));
                headerCellValor.BackgroundColor = headerBackgroundColor;
                headerCellValor.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(headerCellValor);

                PdfPCell headerCellEtiqueta = new PdfPCell(new Phrase("Etiqueta", headerFont));
                headerCellEtiqueta.BackgroundColor = headerBackgroundColor;
                headerCellEtiqueta.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(headerCellEtiqueta);

                // Dados dos equipamentos
                iTextSharp.text.Font dataFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10);

                decimal valorTotal = 0;

                BaseColor rowColor1 = new BaseColor(238, 238, 238); // Cor #EEEEEE
                BaseColor rowColor2 = BaseColor.WHITE; // Cor #FFF
                bool alternateRowColor = false;

                foreach (Equipamento equipamento in equipamentos)
                {
                    PdfPCell cellID = new PdfPCell(new Phrase(equipamento.ID_equipamento.ToString(), dataFont));
                    cellID.BackgroundColor = alternateRowColor ? rowColor1 : rowColor2;
                    cellID.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cellID);

                    PdfPCell cellNome = new PdfPCell(new Phrase(equipamento.Nome, dataFont));
                    cellNome.BackgroundColor = alternateRowColor ? rowColor1 : rowColor2;
                    cellNome.HorizontalAlignment = Element.ALIGN_LEFT;
                    table.AddCell(cellNome);

                    PdfPCell cellValor = new PdfPCell(new Phrase(equipamento.Valor.ToString(), dataFont));
                    cellValor.BackgroundColor = alternateRowColor ? rowColor1 : rowColor2;
                    cellValor.HorizontalAlignment = Element.ALIGN_LEFT;
                    table.AddCell(cellValor);

                    PdfPCell cellEtiqueta = new PdfPCell(new Phrase(equipamento.Etiqueta, dataFont));
                    cellEtiqueta.BackgroundColor = alternateRowColor ? rowColor1 : rowColor2;
                    cellEtiqueta.HorizontalAlignment = Element.ALIGN_LEFT;
                    table.AddCell(cellEtiqueta);

                    valorTotal += decimal.TryParse(equipamento.Valor, out decimal valor) ? valor : 0;
                    alternateRowColor = !alternateRowColor;
                }

                // Adicione a tabela ao documento
                doc.Add(table);

                // Adicione uma linha separadora
                doc.Add(new Chunk("\n"));

                // Adicione o valor total dos equipamentos
                iTextSharp.text.Paragraph totalParagraph = new iTextSharp.text.Paragraph($"Valor total dos equipamentos: {valorTotal.ToString("C")}", dataFont);
                totalParagraph.Alignment = Element.ALIGN_RIGHT;
                doc.Add(totalParagraph);

                // Adicione espaço em branco entre a tabela e a imagem
                doc.Add(new Chunk("\n"));
                doc.Add(new Chunk("\n"));
                doc.Add(new Chunk("\n"));
                doc.Add(new Chunk("\n"));

                // Adicione uma linha de separação simulada
                //addSeparatorLine(document);

                // Adicione a imagem centralizada
                string imageUrl = "[caminho da foto para aparecer no relatorio]";
                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(new Uri(imageUrl));
                image.Alignment = Element.ALIGN_CENTER;
                doc.Add(image);

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
