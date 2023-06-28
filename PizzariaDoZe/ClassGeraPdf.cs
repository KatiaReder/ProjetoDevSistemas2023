using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using PizzariaDoZe_DAO;
using System.Configuration;
using System.Data;
using static PizzariaDoZe.ClassEnums;

namespace PizzariaDoZe
{
    internal class ClassGeraPdf
    {
        readonly static string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        readonly static string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        //métodos
        public static string pathArquivo(string nome)
        {
            SaveFileDialog savePath = new()
            {
                Title = "Selecione o local e o nome para salvar seu relatório",
                Filter = "Arquivo|*.pdf",
                FileName = nome + "-" + Convert.ToString(DateTime.Now).Replace("/", "-").Replace(":", "-") + ".pdf"
            };
            if (savePath.ShowDialog() == DialogResult.OK)
            {
                return Convert.ToString(savePath.FileName);
            }
            else
            {
                return "PizzariaDoZe.pdf";
            }
        }
        public static void PdfPedido(string pathArquivo, int id)
        {
            try
            {
                using PdfWriter pdfWriter = new(pathArquivo);
                using PdfDocument pdfDocument = new(pdfWriter);
                using Document document = new(pdfDocument, PageSize.A4.Rotate());
                //PageSize.A4 - vertical ou PageSize.A4.Rotate() - horizontal
                document.Add(new Paragraph("Pizzaria do Zé").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20));
                document.Add(new Paragraph("Pedido" + ((id == 0) ? "s" : ": " + id)).SetTextAlignment(TextAlignment.CENTER).SetFontSize(15));
                document.Add(new LineSeparator(new SolidLine()));
                Table table = new(7, false);
                table.SetWidth(UnitValue.CreatePercentValue(100));
                table.SetTextAlignment(TextAlignment.LEFT);
                table.AddCell(new Cell().Add(new Paragraph("ID")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("ClienteID")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("FuncionarioId")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("Entrega")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("StatusPedido")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("ValorTotal")).SetBorder(Border.NO_BORDER));
                table.AddCell(new Cell().Add(new Paragraph("TipoPagamento")).SetBorder(Border.NO_BORDER));
                // realiza a busca no Banco de Dados
                PedidoDAO pedidoDAO = new(provider, strConnection);
                Pedido pedido = new()
                {
                    Id = id,
                    
                };
                DataTable linhas = pedidoDAO.Buscar(pedido);
                foreach (DataRow row in linhas.Rows)
                {
                    table.AddCell(new Cell().Add(new Paragraph(row[0].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[1].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[2].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[3].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[4].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[5].ToString())).SetBorder(Border.NO_BORDER));
                    table.AddCell(new Cell().Add(new Paragraph(row[6].ToString())).SetBorder(Border.NO_BORDER));
                    // busca e seleciona os itens do sabor
                    pedido.Id = int.Parse(row[0].ToString());
                }
                //adiciona a tabela criada, já com os dados, no documento
                document.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

