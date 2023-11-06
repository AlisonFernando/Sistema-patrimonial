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
            comboBoxColaborador.ValueMember = "ID_colaborador";    // Define a coluna a ser usada como valor selecionado
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
            int idColaboradorSelecionado = (int)comboBoxColaborador.SelectedValue;

            EquipamentoBLL equipamentoBLL = new EquipamentoBLL();
            ColaboradorBLL colaboradorBLL = new ColaboradorBLL();
            Colaborador colaborador = colaboradorBLL.ObterColaboradorPorID(idColaboradorSelecionado);
            List<Equipamento> equipamentos = equipamentoBLL.ObterEquipamentosPorColaborador(idColaboradorSelecionado);

            Document document = new Document();

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "Salvar Relatório PDF";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoRelatorio = saveFileDialog.FileName;
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(caminhoRelatorio, FileMode.Create));

                    document.Open();
                    document.Add(new Paragraph("Nome do Colaborador: " + colaborador.NomeColaborador));

                    PdfPTable table = new PdfPTable(2);
                    table.AddCell("ID Equipamento");
                    table.AddCell("Nome Equipamento");

                    foreach (Equipamento equipamento in equipamentos)
                    {
                        table.AddCell(equipamento.ID_equipamento.ToString());
                        table.AddCell(equipamento.Nome);
                    }

                    document.Add(table);
                }
            }
            finally
            {
                document.Close();

                // Abra o arquivo PDF com o leitor de PDF padrão
                //Process.Start(caminhoRelatorio);
            }
        }
    }
}
