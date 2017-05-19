using System;
using OpenQA.Selenium;

namespace Blinnikov.Instouch.Services 
{
    public class LoginService : ILoginService 
    {
        private readonly IWebDriver _driver;
        private readonly IElementFinder _elementFinder;
        private readonly IAppSettings _appSettings;

        public LoginService(IWebDriver driver, IElementFinder elementFinder, IAppSettings appSettings)
        {
            this._driver = driver;
            this._elementFinder = elementFinder;
            this._appSettings = appSettings;
        }

        public bool Login()
        {
            this._driver.Navigate().GoToUrl(@"https://instagram.com");
            IWebElement loginLink = this._elementFinder.GetLoginLink();
            loginLink.Click();

            IWebElement usernameInput = this._elementFinder.GetUsernameInput();
            usernameInput.SendKeys(this._appSettings.Username);
            IWebElement passwordInput = this._elementFinder.GetPasswordInput();
            passwordInput.SendKeys(this._appSettings.Password);
            IWebElement loginButton = this._elementFinder.GetLoginButton();
            loginButton.Click();

            return true;
        }
    }
}
