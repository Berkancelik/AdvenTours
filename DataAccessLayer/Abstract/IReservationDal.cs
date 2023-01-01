using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal : IGenericDal<Reservation>
    {
        List<Reservation> GetListWithReservaitonByWaitApproval(int id);
        List<Reservation> GetListWithReservaitonByAccepted(int id);
        List<Reservation> GetListWithReservaitonByPrevious(int id);

    }
}
