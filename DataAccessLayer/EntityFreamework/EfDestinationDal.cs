using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer.EntityFreamework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
        public List<Destination> GetDestiationWithGuide(int id)
        {
            using (var c = new Context())
            {
                return c.Destinations.Where(x => x.Id == id).Include(x => x.Guide).ToList();
            }
        }

      
    }
}
