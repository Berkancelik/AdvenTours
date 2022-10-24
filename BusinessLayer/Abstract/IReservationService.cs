using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> GetListWithReservaitonByWaitApproval(int id);
        List<Reservation> GetListWithReservaitonByAccepted(int id);
        List<Reservation> GetListWithReservaitonByPrevious(int id);
    }
}
