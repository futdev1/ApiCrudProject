using ApiTest.Models;
using ApiTest.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiTest.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService clientService;

        public ClientsController(IClientService clientService)
        {
            this.clientService = clientService; 
        }

        [HttpGet]
        public async Task<ActionResult<Client>> Get (string name)
        {
            var result = await clientService.GetAsync(p => p.FirstName == name);

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Client>> Create (Client client)
        {
            var result = await clientService.CreateAsync(client);

            return Ok(result);
        }
    }
}
