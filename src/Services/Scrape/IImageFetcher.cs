using System.Collections.Generic;

namespace Blinnikov.Instouch.Services.Scrape
{
    public interface IImageFetcher
    {
        IEnumerable<string> ByTag(string tag);
    }
}
