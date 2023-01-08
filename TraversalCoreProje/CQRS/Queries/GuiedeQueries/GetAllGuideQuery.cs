using MediatR;
using System.Collections.Generic;
using TraversalCoreProje.CQRS.Results.GuideResult;

namespace TraversalCoreProje.CQRS.Queries.GuiedeQueries
{
    public class GetAllGuideQuery:IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
