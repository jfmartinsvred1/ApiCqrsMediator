using ApiCqrsMediator.Domain.Commands.Requests;
using ApiCqrsMediator.Domain.Commands.Responses;
using ApiCqrsMediator.Domain.Handlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiCqrsMediator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController:ControllerBase
    {
        private readonly string _connectioString;
        
        public CustomerController(IConfiguration configuration)
        {
            _connectioString = configuration.GetConnectionString("ApiCqrs");
        }


        [HttpPost]
        public Task<CreateCustomerResponse> Create(
            [FromServices] IMediator handler,
            [FromBody]CreateCustomerRequest command
        )
        {
            return handler.Send(command);
        }
    }
}
