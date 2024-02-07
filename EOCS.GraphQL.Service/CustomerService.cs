using HotChocolate.AzureFunctions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using System.Threading.Tasks;

namespace EOCS.GraphQL.Service
{
    public class CustomerService
    {
        private readonly IGraphQLRequestExecutor _executor;

        public CustomerService(IGraphQLRequestExecutor executor)
        {
            _executor = executor;
        }

        [FunctionName(nameof(Run))]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "graphql/{**slug}")] HttpRequest req)
        {
            return await _executor.ExecuteAsync(req);
        }
    }
}
