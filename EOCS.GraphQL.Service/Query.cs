using EOCS.GraphQL.Service.Data;
using EOCS.GraphQL.Service.Repositories.Interfaces;
using HotChocolate;
using System.Collections.Generic;

namespace EOCS.GraphQL.Service
{
    public class Query
    {
        public List<Customer> GetCustomers([Service] ICustomerRepository customerRepository)
        {
            return customerRepository.GetAllCustomers();
        }
    }
}
