using System.Data.SqlClient;
using ApiCqrsMediator.Domain.Commands.Requests;
using Dapper;

namespace ApiCqrsMediator.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly string _connectionString;
        public CustomerRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ApiCqrs");
        }
        public void Add(CreateCustomerRequest request)
        {
            var parameters = new
            {
                request.Name,
                request.Email,
            };
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                const string sql = "INSERT INTO Customers (Name, Email) VALUES (@Name, @Email)";
                sqlConnection.Execute(sql, parameters);

            }
        }
    }
}
