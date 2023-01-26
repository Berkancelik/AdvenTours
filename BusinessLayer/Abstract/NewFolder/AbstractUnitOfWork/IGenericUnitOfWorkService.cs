using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract.NewFolder.AbstractUnitOfWork
{
    public interface IGenericUnitOfWorkService<T>
    {
        void TInsert(T t);
        void TUpdate(T t);
        void TMultiUpdate(List<Account> t);
        T GetById(int id);

    }
}
