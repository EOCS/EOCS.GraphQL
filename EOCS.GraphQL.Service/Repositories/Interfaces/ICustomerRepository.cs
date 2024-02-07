using EOCS.GraphQL.Service.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOCS.GraphQL.Service.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
    }
}
