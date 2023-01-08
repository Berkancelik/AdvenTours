using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;

        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreteDestinationCommands commands)
        {
            _context.Destinations.Add(new Destination
            {
                City = commands.City,
                Price = commands.Price,
                DayNight = commands.DayNight,
                Capacity = commands.Capacity,
                Status = true
            });
            _context.SaveChanges();

        }

    }

}
