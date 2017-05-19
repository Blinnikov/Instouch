using Blinnikov.Instouch.Services;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Blinnikov.Instouch
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IWebDriver>(serviceProvider => {
                var driverPath = "./bin/Debug/netcoreapp1.1";
                var driver = new ChromeDriver(driverPath);
                return driver;
            });
            services.AddTransient<ILoginService, LoginService>();
            services.AddTransient<IElementFinder, ElementFinder>();
        }
    }
}
