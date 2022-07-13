using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> GetListWithReservaitonByWaitApproval(int id);
        List<Reservation> GetListWithReservaitonByAccepted(int id);
        List<Reservation> GetListWithReservaitonByPrevious(int id);
    }
}
