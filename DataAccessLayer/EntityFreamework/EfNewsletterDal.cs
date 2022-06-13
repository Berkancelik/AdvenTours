using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFreamework
{
    public class EfNewsletterDal : GenericRepository<Newsletter>, INewsletterDal
    {
    }
}
