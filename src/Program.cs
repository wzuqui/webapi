using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace RavexSolution.WebApi
{
    public static class Program
    {
        public static void Main(string[] pArgs)
        {
            CreateHostBuilder(pArgs)
                .Build()
                .Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] pArgs)
        {
            return Host.CreateDefaultBuilder(pArgs)
                .ConfigureWebHostDefaults(pWebBuilder => pWebBuilder.UseStartup<Startup>())
                .UseSerilog((pBuilder
                    , pConfiguration) =>
                {
                    pConfiguration.ReadFrom.Configuration(pBuilder.Configuration);
                });
        }
    }
}
