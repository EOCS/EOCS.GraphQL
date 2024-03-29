namespace EOCS.GraphQL.Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            
            app.UseDefaultFiles();
            
            app.UseStaticFiles();
            
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Request Handled and Response Generated");
            });
            
            app.Run();
        }
    }
}
