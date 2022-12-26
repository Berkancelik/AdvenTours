using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TaversalCoreApi.DAL.Context;

namespace TaversalCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisiterController : ControllerBase
    {

        [HttpGet]
        public IActionResult VisitorList()
        {
            using (var context = new VisitorContext())
            {
                var values = context.Visitors.ToList();
                return Ok(values);
            }
        }

        [HttpPost]
        public IActionResult VisitorAdd(VisitorContext visitor)
        {
            using(var context = new VisitorContext())
            {
                context.Add(visitor);
                context.SaveChanges();
                return Ok();
            }   
        }


    }
}
