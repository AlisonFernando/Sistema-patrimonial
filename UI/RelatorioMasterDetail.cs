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
using System.Diagnostics;
using iTextSharp.text.pdf.draw;

namespace UI
{
    public partial class RelatorioMasterDetail : Form
    {
        public ColaboradorBLL colaboradorBLL = new ColaboradorBLL();
        public RelatorioMasterDetail()
        {
            InitializeComponent();
        }
        private void RelatorioMasterDetail_Load(object sender, EventArgs e)
        {
            PreencherComboBoxColaboradores();
        }

        private string caminhoDestino;

        private void PreencherComboBoxColaboradores()
        {
            DataTable dt = colaboradorBLL.CarregarColaborador();

            comboBoxColaborador.DisplayMember = "Nome"; // Define a coluna a ser exibida
            comboBoxColaborador.ValueMember = "ID_colaborador"; // Define a coluna a ser usada como valor selecionado
            comboBoxColaborador.DataSource = dt;
        }
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
                int idColaboradorSelecionado = (int)((DataRowView)comboBoxColaborador.SelectedItem)["ID_colaborador"];

                EquipamentoBLL equipamentoBLL = new EquipamentoBLL();
                ColaboradorBLL colaboradorBLL = new ColaboradorBLL();
                Colaborador colaborador = colaboradorBLL.ObterColaboradorPorID(idColaboradorSelecionado);
                List<Equipamento> equipamentos = equipamentoBLL.ObterEquipamentosPorColaborador(idColaboradorSelecionado);

                Document document = new Document();
                string caminhoRelatorio = string.Empty;

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Salvar Relatório PDF";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    caminhoRelatorio = saveFileDialog.FileName;
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(caminhoRelatorio, FileMode.Create));

                    document.Open();

                    // Adicione o título
                    iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK);
                    Paragraph title = new Paragraph("Equipamentos associados ao colaborador", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    document.Add(new Chunk("\n"));
                    document.Add(title);
                    

                    // Adicione o nome do colaborador
                    document.Add(new Chunk("\n"));
                    iTextSharp.text.Font nameFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.DARK_GRAY);
                    Paragraph name = new Paragraph("Nome do Colaborador: " + colaborador.NomeColaborador, nameFont);
                    name.Alignment = Element.ALIGN_LEFT;
                    document.Add(name);

                    // Adicione uma tabela para os equipamentos
                    PdfPTable table = new PdfPTable(4);
                    table.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER; // Remova as bordas padrão
                    table.WidthPercentage = 100; // Preencha a largura da página

                    // Adicione cabeçalhos à tabela
                    table.AddCell(getHeaderCell("ID"));
                    table.AddCell(getHeaderCell("Equipamento"));
                    table.AddCell(getHeaderCell("Descricao"));
                    table.AddCell(getHeaderCell("Etiqueta"));

                    // Adicione linhas à tabela
                    BaseColor rowColor1 = new BaseColor(238, 238, 238); // Cor #EEEEEE
                    BaseColor rowColor2 = BaseColor.WHITE; // Cor #FFF
                    bool alternateRowColor = false;

                    foreach (Equipamento equipamento in equipamentos)
                    {
                        table.AddCell(getCell(equipamento.ID_equipamento.ToString(), rowColor1, rowColor2, alternateRowColor));
                        table.AddCell(getCell(equipamento.Nome, rowColor1, rowColor2, alternateRowColor));
                        table.AddCell(getCell(equipamento.Descricao, rowColor1, rowColor2, alternateRowColor));
                        table.AddCell(getCell(equipamento.Etiqueta, rowColor1, rowColor2, alternateRowColor));

                        alternateRowColor = !alternateRowColor;
                    }

                    // Adicione a tabela ao documento
                    document.Add(table);

                    // Adicione espaço em branco entre a tabela e a imagem
                    document.Add(new Chunk("\n"));
                    document.Add(new Chunk("\n"));
                    document.Add(new Chunk("\n"));
                    document.Add(new Chunk("\n"));


                    DateTime dataHoraAtual = DateTime.Now;
                    string dataHoraFormatada = "Data e Hora de Geração: " + dataHoraAtual.ToString("dd/MM/yyyy HH:mm:ss");
                    Paragraph dataHora = new Paragraph(dataHoraFormatada);
                    dataHora.Alignment = Element.ALIGN_RIGHT;
                    document.Add(dataHora);

                    // Adicione a imagem centralizada
                    string imageUrl = "https://www.scotconsultoria.com.br/img/relatorio_sys.png";
                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(new Uri(imageUrl));
                    image.Alignment = Element.ALIGN_CENTER;
                    document.Add(image);

                    // Feche o documento
                    document.Close();
                    MessageBox.Show("Relatório gerado com sucesso, salvo em: " + caminhoRelatorio, "PDF Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PdfPCell getHeaderCell(string text)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text));
            BaseColor rowColor3 = new BaseColor(63, 96, 35); // Cor #Verde Scot
            cell.BackgroundColor = rowColor3;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.BorderWidth = 0.5f; // Adicione a configuração da borda
            cell.BorderColor = BaseColor.BLACK; // Adicione a configuração da cor da borda
            cell.Padding = 5;

            // Defina a cor do texto como branca
            cell.Phrase.Font.Color = BaseColor.WHITE;
            cell.Phrase.Font.SetStyle(1); // Defina o estilo da fonte como negrito

            return cell;
        }

        private PdfPCell getCell(string text, BaseColor backgroundColor, BaseColor textColor, bool alternateRowColor)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text));
            cell.BackgroundColor = alternateRowColor ? backgroundColor : BaseColor.WHITE;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            cell.Padding = 5;

            // Defina as bordas da célula
            cell.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
            cell.BorderWidth = 0.5f;
            BaseColor rowColor4 = new BaseColor(63, 96, 35);
            cell.BorderColor = rowColor4;

            return cell;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
