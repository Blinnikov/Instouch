using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var driver = new ChromeDriver()) {
                driver.Navigate().GoToUrl(@"https://vk.com");
            }
            
            Console.ReadKey();
        }
    }
}
