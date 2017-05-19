using System;
using Blinnikov.Instouch.Models;
using OpenQA.Selenium;

namespace Blinnikov.Instouch.Services
{
    public class ElementFinder : IElementFinder
    {
        private readonly IWebDriver _driver;

        public ElementFinder(IWebDriver driver)
        {
            this._driver = driver;
        }

        public IWebElement GetLoginLink()
        {
            return this._driver.FindElement(By.XPath(Element.LoginLink));
        }
    }
}