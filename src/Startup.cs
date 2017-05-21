using Blinnikov.Instouch.Services;
using Blinnikov.Instouch.Services.Common;
using Blinnikov.Instouch.Services.Scrape;
using Blinnikov.Instouch.Services.Steps;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Blinnikov.Instouch
{
    public class Startup
    {
        IConfigurationRoot Configuration { get; }

        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");
            this.Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IWebDriver>(serviceProvider => {
                var driverPath = "./bin/Debug/netcoreapp1.1";
                var driver = new ChromeDriver(driverPath);
                return driver;
            });
            services.AddSingleton<IConfigurationRoot>(this.Configuration);
            services.AddSingleton<IAppSettings, AppSettings>();
            services.AddTransient<ILoginService, LoginService>();
            services.AddTransient<IElementFinder, ElementFinder>();
            services.AddTransient<IImageFetcher, ImageFetcher>();
            services.AddTransient<IWorker, Worker>();
        }
    }
}
