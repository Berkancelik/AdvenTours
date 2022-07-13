using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFreamework
{
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> ListWithReservaitonByAccepted(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> ListWithReservaitonByPrevious(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservaitonByWaitApproval(int id)
        {
            throw new NotImplementedException();

            //using (var context = new Context())
            //{
            //    return context.Reservations.Include(x => x.loc);
            //}
        }
    }
}
