using ApiCqrsMediator.Domain.Commands.Requests;

namespace ApiCqrsMediator.Repository
{
    public interface ICustomerRepository
    {
        void Add(CreateCustomerRequest request);
    }
}
