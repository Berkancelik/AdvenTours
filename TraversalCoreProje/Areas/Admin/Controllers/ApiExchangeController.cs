using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using DocumentFormat.OpenXml.Office2021.DocumentTasks;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using TraversalCoreProje.Areas.Admin.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    public class ApiExchangeController : Controller
    {
        [Area("Admin")]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            List <BookingExchangeViewModel2> bookingExchangeViewModel = new List<BookingExchangeViewModel2>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?currency=AED&locale=en-gb"),
                Headers =
    {
        { "X-RapidAPI-Key", "7addc1de1bmsh4201c7eaa13e85bp14f8f2jsne9a7771929cc" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values =  JsonConvert.DeserializeObject<BookingExchangeViewModel2>(body);
                return View(values.base_currency);

            }
        }
    }
}
