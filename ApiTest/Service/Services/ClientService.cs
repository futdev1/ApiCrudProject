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

        public Task<bool> DeleteAsync(Expression<Func<Client, bool>> predicate)
        {
            return clientRepository.DeleteAsync(predicate);
        }

        public IQueryable<Client> GetAllAsync(Expression<Func<Client, bool>> predicate = null)
        {
            return clientRepository.GetAllAsync(predicate);
        }

        public Task<Client> GetAsync(Expression<Func<Client, bool>> predicate)
        {
            return clientRepository.GetAsync(predicate);
        }

        public Client UpdateAsync(Client entity)
        {
            return clientRepository.UpdateAsync(entity);
        }
    }
}
