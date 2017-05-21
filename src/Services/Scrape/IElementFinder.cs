using OpenQA.Selenium;

namespace Blinnikov.Instouch.Services.Scrape
{
    public interface IElementFinder
    {
        IWebElement GetLoginLink();
        IWebElement GetUsernameInput();
        IWebElement GetPasswordInput();
        IWebElement GetLoginButton();
    }
}
