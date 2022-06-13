using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;


namespace DataAccessLayer.EntityFreamework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
    }
}
