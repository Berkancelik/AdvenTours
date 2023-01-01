using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;


namespace DataAccessLayer.EntityFreamework
{
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
        Context context = new Context();

        public void ChangeToFalseByGuide(int id)
        {
            var values = context.Guides.Find(id);
            values.Status = false;
            context.Update(values);
            context.SaveChanges();
        }

        public void ChangeToTrueByGuide(int id)
        {
            var values = context.Guides.Find(id);
            values.Status = true;
            context.SaveChanges();
        }
    }
}
