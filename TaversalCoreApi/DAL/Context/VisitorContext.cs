using Microsoft.EntityFrameworkCore;
using TaversalCoreApi.DAL.Entites;

namespace TaversalCoreApi.DAL.Context
{
    public class VisitorContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-IITT7DV;Initial Catalog=TraversalDbApi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Visitor>   Visitors { get; set; } 
    }
}
