using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace TraversalCoreProje.Controllers
{
    public class ExcelController : Controller
    {
        public IActionResult Index()
        {
            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("Sayfa1");
            workSheet.Cells[1, 1].Value = "Rota";
            workSheet.Cells[1, 2].Value = "Rehber";
            workSheet.Cells[1, 3].Value = "Kontejan";

            workSheet.Cells[2, 1].Value = "Gürcistan Batum turu";
            workSheet.Cells[2, 2].Value = "Berkan Çelik";
            workSheet.Cells[2, 3].Value = "50";

            workSheet.Cells[3, 1].Value = "Ardahan Samsun turu";
            workSheet.Cells[3, 2].Value = "Kübra Çelik";
            workSheet.Cells[3, 3].Value = "55";

            var bytes = excel.GetAsByteArray();

            return File(bytes, "application/vnd.openxmlformats-ofiicedocument.spreadsheetml.sheet", "dosya1.xlsx");



            return View();
        }
    }
}
