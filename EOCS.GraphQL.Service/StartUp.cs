using EOCS.GraphQL.Service;
using EOCS.GraphQL.Service.Repositories;
using EOCS.GraphQL.Service.Repositories.Interfaces;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.DependencyInjection;

[assembly: WebJobsStartup(typeof(StartUp))]
namespace EOCS.GraphQL.Service
{
    public class StartUp : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            ConfigureServices(builder.Services);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ICustomerRepository, MockCustomerRepository>();

            services.AddGraphQLFunction().AddQueryType<Query>();
        }
    }
}
