using ApiTest.Data.IRepositories;
using ApiTest.Models;
using ApiTest.Service.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiTest.Service.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }


        public Task<Client> CreateAsync(Client entity)
        {
            return clientRepository.CreateAsync(entity);
        }

        public Task<Client> DeleteAsync(Expression<Func<Client, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Client>> GetAllAsync(Expression<Func<Client, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetAsync(Expression<Func<Client, bool>> predicate)
        {
            return clientRepository.GetAsync(predicate);
        }

        public Task<Client> UpdateAsync(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
