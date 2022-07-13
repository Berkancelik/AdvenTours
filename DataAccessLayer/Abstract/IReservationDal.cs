using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal : IGenericDal<Reservation>
    {
        List<Reservation> GetListWithReservaitonByWaitApproval(int id);
        List<Reservation> GetListWithReservaitonByAccepted(int id);
        List<Reservation> GetListWithReservaitonByPrevious(int id);

    }
}
