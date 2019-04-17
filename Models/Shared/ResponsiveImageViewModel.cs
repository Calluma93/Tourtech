
namespace Tourtech.Models.Shared
{
    public class ResponsiveImageViewModel : ImageViewModel
    {
        public ResponsiveImageViewModel(string title, string imageUrl, string mobileImageUrl)
            : base(title, imageUrl)
        {
            MobileImageUrl = mobileImageUrl;
        }

        public string MobileImageUrl { get; private set; }
    }
}
