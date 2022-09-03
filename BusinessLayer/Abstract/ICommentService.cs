using EntityLayer.Concrete;
using System.Collections.Generic;


namespace BusinessLayer.Abstract
{
    public interface ICommentService: IGenericService<Comment>
    {
         List<Comment> TGetDestinaitonById(int id);
        List<Comment> GetListCommentWithDestination();


    }
}
