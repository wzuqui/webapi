using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace RavexSolution.WebApi
{
    public class Startup
    {
        public void Configure(IApplicationBuilder pApp
            , IWebHostEnvironment pEnv)
        {
            pApp.UseDeveloperExceptionPage();
            pApp.UseSwagger();
            pApp.UseSwaggerUI(pC => pC.SwaggerEndpoint("/swagger/v1/swagger.json", "RavexSolution.WebApi v1"));
            pApp.UseRouting();
            pApp.UseEndpoints(pEndpoints => { pEndpoints.MapControllers(); });
        }

        public void ConfigureServices(IServiceCollection pServices)
        {
            pServices
                .AddControllers()
                .AddXmlDataContractSerializerFormatters();

            pServices.AddSwaggerGen(p =>
            {
                p.SwaggerDoc("v1"
                    , new OpenApiInfo
                    {
                        Title = "RavexSolution.WebApi"
                        , Version = "v1"
                    });
            });
        }
    }
}
