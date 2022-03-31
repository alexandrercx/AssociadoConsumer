using API.Configuration;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace AssociadoConsumer
{
    public class Startup
    {
        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false);
            Configuration = builder.Build();
        }
        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Contexto>(options =>
                      options.UseSqlServer("Data Source=192.168.100.5,1433;Initial Catalog=BoaSaude_Associado2;User ID=associado;Password=associado;"));
            services.AddDependencyInjectionSetup();
            // services.AddDatabaseSetup(Configuration);
            services.AddTransient<AssociadoConsumer>();

        }
    }
}
