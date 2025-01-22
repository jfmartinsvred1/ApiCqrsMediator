using ApiCqrsMediator.Domain.Commands.Requests;
using ApiCqrsMediator.Domain.Commands.Responses;
using ApiCqrsMediator.Repository;
using MediatR;

namespace ApiCqrsMediator.Domain.Handlers
{
    public class CreateCustomerHandler:IRequestHandler<CreateCustomerRequest,CreateCustomerResponse>
    {
        private readonly ICustomerRepository _customerRepository;

        public CreateCustomerHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public  Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            //Verifica se o cliente já está cadastrado
            //Valida os dados
            //Insere o cliente
             _customerRepository.Add(request);
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
