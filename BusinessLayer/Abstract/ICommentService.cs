using EntityLayer.Concrete;
using System.Collections.Generic;


namespace BusinessLayer.Abstract
{
    public interface ICommentService: IGenericService<Comment>
    {
        public List<Comment> TGetDestinaitonById(int id);

    }
}
