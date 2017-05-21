using System;
using System.Threading;
using Blinnikov.Instouch.Services.Scrape;
using OpenQA.Selenium;

namespace Blinnikov.Instouch.Services.Steps
{
    public class LikeService : ILikeService
    {
        private readonly IWebDriver _driver;
        private readonly IImageFetcher _fetch;
        private readonly IElementFinder _elementFinder;

        public LikeService(IWebDriver driver, IImageFetcher fetch, IElementFinder elementFinder)
        {
            this._driver = driver;
            this._fetch = fetch;
            this._elementFinder = elementFinder;
        }

        public void Like(string tag)
        {
            var images = this._fetch.ByTag(tag);
            foreach(var image in images)
            {
                this._driver.Navigate().GoToUrl(image);
                this.ProcessLike();
            }
        }

        private void ProcessLike()
        {
            var likeButton = this._elementFinder.GetLikeButton();
            var unlikeButton = this._elementFinder.GetUnlikeButton();

            // Not liked
            if(likeButton != null && unlikeButton == null) 
            {
                likeButton.Click();
                Thread.Sleep(2000);
                Console.WriteLine("Liked");
            }

            if(likeButton == null && unlikeButton != null)
            {
                Console.WriteLine("Already liked");
            }
        }
    }
}