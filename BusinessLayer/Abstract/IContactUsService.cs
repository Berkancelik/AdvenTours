using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IContactUsService : IGenericService<ContactUS>
    {
        List<ContactUS> TGetListContactUsByTrue();
        List<ContactUS> TGetListContactUsByFalse();
        void TContactUsStatusChangeToFalse(int id);
    }
}
