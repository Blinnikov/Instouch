using System;
using OpenQA.Selenium;

namespace Blinnikov.Instouch.Services 
{
    public class LoginService : ILoginService 
    {
        private readonly IWebDriver _driver;
        private readonly IElementFinder _elementFinder;

        public LoginService(IWebDriver driver, IElementFinder elementFinder)
        {
            this._driver = driver;
            this._elementFinder = elementFinder;
        }

        public bool Login()
        {
            this._driver.Navigate().GoToUrl(@"https://instagram.com");
            IWebElement loginLink = this._elementFinder.GetLoginLink();
            loginLink.Click();

            IWebElement usernameInput = this._elementFinder.GetUsernameInput();
            usernameInput.SendKeys("ibazzva");

            return true;
        }
    }
}
