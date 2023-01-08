using MediatR;
using TraversalCoreProje.CQRS.Queries.DestinationQueries;
using TraversalCoreProje.CQRS.Results.GuideResult;

namespace TraversalCoreProje.CQRS.Queries.GuiedeQueries
{
    public class GetGuideByIdQuery:IRequest<GetGuideByIdQueryResult>
    {
        public int Id { get; set; }

        public GetGuideByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
