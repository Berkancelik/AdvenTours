using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class AnnoucementManager : IAnnoucementService
    {
        private readonly IAnnoucementDal _annoucementDal;

        public AnnoucementManager(IAnnoucementDal annoucementDal)
        {
            _annoucementDal = annoucementDal;
        }

        public void TAdd(Annoucement t)
        {
            _annoucementDal.Insert(t);
        }

        public void TDelete(Annoucement t)
        {
            _annoucementDal.Delete(t);
        }

        public Annoucement TGetByID(int id)
        {
            return _annoucementDal.GetById(id);
        }

        public List<Annoucement> TGetList()
        {
            return _annoucementDal.GetList();
        }

        public void TUpdate(Annoucement t)
        {
            _annoucementDal.Update(t);
        }
    }
}
