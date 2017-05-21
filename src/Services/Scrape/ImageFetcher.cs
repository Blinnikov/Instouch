using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace Blinnikov.Instouch.Services.Scrape
{
    public class ImageFetcher : IImageFetcher
    {
        private readonly IWebDriver _driver;

        public ImageFetcher(IWebDriver driver)
        {
            this._driver = driver;
        }

        IEnumerable<string> IImageFetcher.ByTag(string tag)
        {
            var trimmedTag = tag.TrimStart('#');
            var tagPage = $"https://www.instagram.com/explore/tags/{trimmedTag}";
            this._driver.Navigate().GoToUrl(tagPage);
            
            return Enumerable.Empty<string>();
        }
    }
}
