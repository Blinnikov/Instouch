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

        public List<string> ByTag(string tag, bool skipTopPosts = true)
        {
            var trimmedTag = tag.TrimStart('#');
            var tagPage = $"https://www.instagram.com/explore/tags/{trimmedTag}";
            this._driver.Navigate().GoToUrl(tagPage);
            
            var rootElement = this.GetRootElement(skipTopPosts);
            Console.WriteLine("Root element found");

            var linkElements = rootElement.FindElements(By.TagName("a"));
            Console.WriteLine($"Links found - {linkElements.Count}");
            var links = linkElements.Select(le => le.GetAttribute("href")).ToList();
            
            return links;
        }

        private IWebElement GetRootElement(bool skipTopPosts){
            if(!skipTopPosts)
            {
                return this._driver.FindElement(By.TagName("main"));;
            }

            // 0 - Top Posts
            // 1 - Most Recent
            var divs = this._driver.FindElements(By.CssSelector("main > article > div"));
            return divs[1];
        }
    }
}
