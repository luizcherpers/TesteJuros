using Calculo.Application.Configuration;
using Calculo.Application.Interfaces;
using Calculo.Application.Services;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Calculo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMediatR(typeof(Startup));
            services.AddControllers();
            services.AddSwaggerConfiguration();
            services.AddHttpClient();
            services.AddScoped<ICalcularJurosService, CalcularJurosService>();
            services.AddScoped<IObterTaxaJuros, ObterTaxaJuros>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwaggerConfiguration();
            app.UseApiConfiguration(env);
        }
    }
}

