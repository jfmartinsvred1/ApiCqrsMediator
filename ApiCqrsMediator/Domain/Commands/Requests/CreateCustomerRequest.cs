using ApiCqrsMediator.Domain.Commands.Responses;
using MediatR;

namespace ApiCqrsMediator.Domain.Commands.Requests
{
    public class CreateCustomerRequest:IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
