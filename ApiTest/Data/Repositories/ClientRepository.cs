using ApiTest.Data.Contexts;
using ApiTest.Data.IRepositories;
using ApiTest.Models;

namespace ApiTest.Data.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(MarketDbContext dbContext) : base (dbContext)
        {
            
        }
    }
}
