using System;
using Blinnikov.Instouch.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Blinnikov.Instouch
{
    class Program
    {
        static void Main(string[] args)
        {
            var driverPath = "./bin/Debug/netcoreapp1.1";
            using(var driver = new ChromeDriver(driverPath)) {
                ILoginService loginService = new LoginService(driver);

                loginService.Login();

                Console.ReadKey();
            }
        }
    }
}
