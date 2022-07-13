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
        List<Reservation> ListWithReservaitonByAccepted(int id);
        List<Reservation> ListWithReservaitonByPrevious(int id);

    }
}
