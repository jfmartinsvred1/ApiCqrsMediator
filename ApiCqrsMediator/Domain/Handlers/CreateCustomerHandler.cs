using ApiCqrsMediator.Domain.Commands.Requests;
using ApiCqrsMediator.Domain.Commands.Responses;
using MediatR;

namespace ApiCqrsMediator.Domain.Handlers
{
    public class CreateCustomerHandler:IRequestHandler<CreateCustomerRequest,CreateCustomerResponse>
    {

        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            //Verifica se o cliente já está cadastrado
            //Valida os dados
            //Insere o cliente
            //Envia email de boas vindas
            var result =  new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Email = request.Email,
                Date = DateTime.Now,
            };
            return Task.FromResult(result);
        }
    }
}
