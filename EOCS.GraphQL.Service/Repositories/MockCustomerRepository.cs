using EOCS.GraphQL.Service.Data;
using EOCS.GraphQL.Service.Repositories.Interfaces;
using System.Collections.Generic;

namespace EOCS.GraphQL.Service.Repositories
{
    public class MockCustomerRepository : ICustomerRepository
    {
        public List<Customer> GetAllCustomers()
        {
            return new List<Customer>()
            {
                new Customer(){ Id = "0001", Name = "Bruce Smith", Age = 45 },
                new Customer(){ Id = "0010", Name = "Melissa Price", Age = 52 }
            };
        }
    }
}
