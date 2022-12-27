using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TaversalCoreApi.DAL.Context;
using TaversalCoreApi.DAL.Entites;

namespace TaversalCoreApi.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
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

        [HttpGet("{id}")]
        public IActionResult VisitorGet(int id)
        {
            using (var context = new VisitorContext())
            {
                var values = context.Visitors.Find(id);
                if (values ==null)
                {
                    return NotFound();

                }
                else
                {
                    return Ok(values);
                }
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVisitor(int id)
        {
            using (var context = new VisitorContext())
            {
                var values = context.Visitors.Find(id);
                if (values == null)
                {
                    return NotFound();
                }
                else
                {
                    context.Remove(values);
                    context.SaveChanges();
                    return Ok();
                }
            }
        }

        [HttpPut]
        public IActionResult UpdateVisitor(Visitor visitor)
        {
            using(var context = new VisitorContext())
            {
                var values = context.Find<Visitor>(visitor.Id);
                if(values == null)
                {
                    return NotFound();
                }
                else
                {
                    values.City = visitor.City;
                    values.Name = visitor.Name;
                    values.Surname = visitor.Surname;
                    values.Name = visitor.Name;
                    values.Country = visitor.Country;
                    context.Update(values);
                    context.SaveChanges();
                    return Ok();
                }
            }
        }


    }
}
