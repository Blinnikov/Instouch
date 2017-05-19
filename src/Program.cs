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

            var driver = serviceProvider.GetService<IWebDriver>();
            var loginService = serviceProvider.GetService<ILoginService>();
            loginService.Login();

            Console.ReadKey();
            driver.Close();
        }

        private static IServiceProvider BuildServiceProvider() {
            var startup = new Startup();
            var services = new ServiceCollection();
            startup.ConfigureServices(services);
            return services.BuildServiceProvider();
        }
    }
}
