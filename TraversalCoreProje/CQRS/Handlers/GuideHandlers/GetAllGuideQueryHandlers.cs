using DataAccessLayer.Concrete;
using MediatR;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TraversalCoreProje.CQRS.Queries.GuiedeQueries;
using TraversalCoreProje.CQRS.Results.GuideResult;

namespace TraversalCoreProje.CQRS.Handlers.GuideHandlers
{
    public class GetAllGuideQueryHandlers : IRequestHandler<GetAllGuideQuery, List<GetAllGuideQueryResult>>
    {
        private readonly Context _context;

        public GetAllGuideQueryHandlers(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideQueryResult
            {
                GuideID = x.GuideID,
                Description = x.Description,
                Image = x.Image,    
                Name = x.Name,

            }).AsNoTracking().ToListAsync();
        }
    }
}
