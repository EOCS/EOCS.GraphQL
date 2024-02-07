using EOCS.GraphQL.Service.Data;
using EOCS.GraphQL.Service.Repositories.Interfaces;
using HotChocolate;
using HotChocolate.Types;
using System.Collections.Generic;

namespace EOCS.GraphQL.Service.Extensions
{
    [ExtendObjectType(typeof(Customer))]
    public class CustomerExtensions
    {
        public List<Customer> GetCustomers([Parent] Customer customer, [Service] ICustomerRepository customerRepository)
        {
            return customerRepository.GetAllCustomers();
        }
    }
}
