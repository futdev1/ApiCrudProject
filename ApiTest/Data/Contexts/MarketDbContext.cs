using ApiTest.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTest.Data.Contexts
{
    public class MarketDbContext : DbContext
    {
        public MarketDbContext(DbContextOptions<MarketDbContext> options)
            : base(options)
        {
            
        }
        

        public virtual DbSet<Client> Clients { get; set; }
    }
}
