using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface IContactUsDal : IGenericDal<ContactUS>
    {
        List<ContactUS> GetListContactUsByTrue();
        List<ContactUS> GetListContactUsByFalse();
        void ContactUsStatusChangeToFalse(int id);
    }
}
