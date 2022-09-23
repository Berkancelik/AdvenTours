using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class ExcelController : Controller
    {
        public IActionResult Index()
        {
           return View();   
        }

        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();
            using (var c = new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    DayNight = x.DayNight,
                    Price = x.Price,
                    Capacity = x.Capacity

                }).ToList();
            }
            return destinationModels;
        }

        public IActionResult StaticExcelReport() {
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

            return File(bytes, "application/vnd.openxmlformats-ofiicedocument.spreadsheetml.sheet", "dosya2.xlsx");



            return View();
        }

        public IActionResult DestinationExcelReport()
        {
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Tur Listesi");
                workSheet.Cell(1, 1).Value = "Şehir";
                workSheet.Cell(1, 2).Value = "Konaklama Süresi";
                workSheet.Cell(1, 3).Value = "Fiyat";
                workSheet.Cell(1, 4).Value = "Kapasite";

                int rowCount = 2;
                foreach (var item in DestinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.City;
                    workSheet.Cell(rowCount, 1).Value = item.DayNight;
                    workSheet.Cell(rowCount, 1).Value = item.Price;
                    workSheet.Cell(rowCount, 1).Value = item.Capacity;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-ofiicedocument.spreadsheetml.sheet", "YeniListe.xlsx");
                }
            }

        }
    }
}

