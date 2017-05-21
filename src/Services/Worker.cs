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
        private readonly ILikeService _likeService;

        public Worker(IWebDriver webDriver, ILoginService loginService, ILikeService likeService)
        {
            this._webDriver = webDriver;
            this._loginService = loginService;
            this._likeService = likeService;
        }

        void IWorker.Run()
        {
            this._loginService.Login();
            Thread.Sleep(5000);
            this._likeService.Like("l4l");

            Console.ReadKey();
            this._webDriver.Close();
        }
    }
}
