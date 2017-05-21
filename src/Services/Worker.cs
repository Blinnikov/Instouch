using System;
using System.Threading;
using Blinnikov.Instouch.Services.Scrape;
using Blinnikov.Instouch.Services.Steps;
using OpenQA.Selenium;

namespace Blinnikov.Instouch.Services
{
    public class Worker : IWorker
    {
        private readonly IWebDriver _webDriver;
        private readonly ILoginService _loginService;
        private readonly IImageFetcher _imageFetcher;

        public Worker(IWebDriver webDriver, ILoginService loginService, IImageFetcher imageFetcher)
        {
            this._webDriver = webDriver;
            this._loginService = loginService;
            this._imageFetcher = imageFetcher;
        }

        void IWorker.Run()
        {
            this._loginService.Login();
            Thread.Sleep(5000);
            this._imageFetcher.ByTag("ремарк");

            Console.ReadKey();
            this._webDriver.Close();
        }
    }
}
