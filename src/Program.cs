using System;
using Blinnikov.Instouch.Services;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Blinnikov.Instouch
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceProvider serviceProvider = BuildServiceProvider();

            var worker = serviceProvider.GetService<IWorker>();
            worker.Run();
        }

        private static IServiceProvider BuildServiceProvider() {
            var startup = new Startup();
            var services = new ServiceCollection();
            startup.ConfigureServices(services);
            return services.BuildServiceProvider();
        }
    }
}
