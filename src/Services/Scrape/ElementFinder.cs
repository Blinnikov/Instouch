using System;
using Blinnikov.Instouch.Models;
using OpenQA.Selenium;

namespace Blinnikov.Instouch.Services.Scrape
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

        public IWebElement GetUsernameInput()
        {
            return this._driver.FindElements(By.XPath(Element.FormInput))[0];
        }

        public IWebElement GetPasswordInput()
        {
            return this._driver.FindElements(By.XPath(Element.FormInput))[1];
        }

        public IWebElement GetLoginButton()
        {
            return this._driver.FindElement(By.XPath(Element.LoginButton));
        }

        public IWebElement GetLikeButton()
        {
            var elements = this._driver.FindElements(By.XPath(Element.LikeButton));
            if(elements.Count == 1)
            {
                return elements[0];
            }

            return null;
        }

        public IWebElement GetUnlikeButton()
        {
            var elements = this._driver.FindElements(By.XPath(Element.UnlikeButton));
            if(elements.Count == 1)
            {
                return elements[0];
            }

            return null;
        }
    }
}
