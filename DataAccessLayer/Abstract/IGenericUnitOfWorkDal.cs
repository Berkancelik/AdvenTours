using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface IGenericUnitOfWorkDal<T> where T : class
    {
        void Insert(T t);
        void Update(T t);
        void MultiUpdate(List<T> t);
        T GetById(int id);

    }
}
