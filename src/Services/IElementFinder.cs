using OpenQA.Selenium;

namespace Blinnikov.Instouch.Services
{
    public interface IElementFinder
    {
        IWebElement GetLoginLink();
        IWebElement GetUsernameInput();
        IWebElement GetPasswordInput();
        IWebElement GetLoginButton();
    }
}
