

using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfreport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            Paragraph paragraph = new Paragraph("Traversal rezervasyon Pdf Raporu");

            document.Add(paragraph);
            document.Close();
            return File("/PdfReports/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }

        public IActionResult StaticCustomReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable pdfPTable = new PdfPTable(3);

            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir Soyadı");
            pdfPTable.AddCell("Misafir TC");

            pdfPTable.AddCell("Berkan ");
            pdfPTable.AddCell("Çelik");
            pdfPTable.AddCell("15665486585");

            pdfPTable.AddCell("Kübra ");
            pdfPTable.AddCell("Çelik");
            pdfPTable.AddCell("10047145681");

            pdfPTable.AddCell("Selim ");
            pdfPTable.AddCell("Haşim");
            pdfPTable.AddCell("455869598774");

            pdfPTable.AddCell("Yuri ");
            pdfPTable.AddCell("Boyka");
            pdfPTable.AddCell("25644589554");

            document.Add(pdfPTable);
            document.Close();

            return File("/PdfReports/dosya2.pdf", "application/pdf", "dosya2.pdf");
        }
    }
}
