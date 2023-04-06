using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface IDestinationDal : IGenericDal<Destination>
    {
        public List<Destination> GetDestiationWithGuide(int id);
        public List<Destination> GetLast4Destinations();
    }
}
