using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IGuideService : IGenericService<Guide>
    {
        void TChangeToFalseByGuide(int id);
        void TChangeToTrueByGuide(int id);

    }
}
