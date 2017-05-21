namespace Blinnikov.Instouch.Models
{
    public static class Element
    {
        public static readonly string LoginLink = "//article/div/div/p/a[text()='Log in']";
        public static readonly string FormInput = "//form/div/input";
        public static readonly string LoginButton = "//form/span/button[text()='Log in']";
        public static readonly string LikeButton = "//a[@role='button']/span[text()='Like']";
        public static readonly string UnlikeButton = "//a[@role='button']/span[text()='Unlike']";
    }
}
