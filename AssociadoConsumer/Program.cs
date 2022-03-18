using Microsoft.Extensions.DependencyInjection;
using System;

namespace AssociadoConsumer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            Startup startup = new Startup();
            startup.ConfigureServices(services);
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetService<AssociadoConsumer>().Consumer();
        }

      

      
    }
}
