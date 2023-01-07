using DataAccessLayer.Concrete;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProje.CQRS.Handlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateDestinationCommands commands)
        {
            var values = _context.Destinations.Find(commands.Id);
            values.City = commands.City;    
            values.DayNight = commands.DayNight;
            values.Price = commands.Price;
            _context.SaveChanges();
        }
    }
}
