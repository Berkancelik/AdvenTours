using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;


namespace DataAccessLayer.EntityFreamework
{
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
    }
}
