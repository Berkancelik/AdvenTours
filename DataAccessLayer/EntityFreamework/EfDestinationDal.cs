using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;


namespace DataAccessLayer.EntityFreamework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
    }
}
