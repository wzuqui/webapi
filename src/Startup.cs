using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace RavexSolution.WebApi
{
    public class Startup
    {
        public void Configure(IApplicationBuilder pApp
            , IWebHostEnvironment pEnv)
        {
            if (pEnv.IsDevelopment())
            {
                pApp.UseDeveloperExceptionPage();
                pApp.UseSwagger();
                pApp.UseSwaggerUI();
            }
            pApp.UseRouting();
            pApp.UseEndpoints(pEndpoints => pEndpoints.MapControllers());
        }

        public void ConfigureServices(IServiceCollection pServices)
        {
            pServices
                .AddControllers()
                .AddXmlDataContractSerializerFormatters();

            pServices
                .AddEndpointsApiExplorer()
                .AddSwaggerGen();
        }
    }
}
