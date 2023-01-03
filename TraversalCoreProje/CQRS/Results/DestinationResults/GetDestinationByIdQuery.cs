namespace TraversalCoreProje.CQRS.Results.DestinationResults
{
    public class GetDestinationByIdQuery
    {
        public int Id { get; set; }

        public GetDestinationByIdQuery(int ıd)
        {
            Id = ıd;
        }

        public string City { get; set; }
        public string Daynight { get; set; }
    }
}
