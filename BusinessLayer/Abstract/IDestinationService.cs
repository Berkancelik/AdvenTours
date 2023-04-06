using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccessLayer.Concrete
{
    public interface IDestinationService : IGenericService<Destination>
    {
        public List<Destination> TGetDestiationWithGuide(int id);
        public List<Destination> TGetLast4Destinations();

    }
}