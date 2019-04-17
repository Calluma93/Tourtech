
using System.Linq;

namespace Services.Models.Retailer
{
    public class RetailerModel
    {
        public RetailerModel(
            string name, string websiteUrl, string desktopImageRelativeUrl, string mobileImageRelativeUrl,
            string backgroundColourHex, string textColourHex
        )
        {
            Name = name;
            WebsiteUrl = websiteUrl;
            WebsiteUrlForDisplay = websiteUrl.Split(':').Last().Trim('/');
            DesktopImageRelativeUrl = desktopImageRelativeUrl;
            MobileImageRelativeUrl = mobileImageRelativeUrl;
            BackgroundColourHex = backgroundColourHex;
            TextColourHex = textColourHex;
        }

        public string Name { get; private set; }

        public string WebsiteUrl { get; private set; }

        public string WebsiteUrlForDisplay { get; private set; }

        public string DesktopImageRelativeUrl { get; private set; }

        public string MobileImageRelativeUrl { get; private set; }

        public string BackgroundColourHex { get; private set; }

        public string TextColourHex { get; private set; }
    }
}
