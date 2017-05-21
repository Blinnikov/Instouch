using System.Collections.Generic;

namespace Blinnikov.Instouch.Services.Scrape
{
    public interface IImageFetcher
    {
        List<string> ByTag(string tag, bool skipTopPosts = true);
    }
}
