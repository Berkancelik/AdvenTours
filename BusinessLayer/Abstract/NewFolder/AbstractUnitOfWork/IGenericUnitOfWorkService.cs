using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.NewFolder.AbstractUnitOfWork
{
    public  interface IGenericUnitOfWorkService<T>
    {
        void TInsert(T t);
        void TUpdate(T t);
        void TMultiUpdate(List<Account> t);
    }
}
