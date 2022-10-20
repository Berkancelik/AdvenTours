using BusinessLayer.Abstract;
using EntityLayer.Concrete;


namespace DataAccessLayer.Concrete
{
    public interface IDestinationService : IGenericService<Destination>
    {
        void TAdd(Destination destination);
    }
}