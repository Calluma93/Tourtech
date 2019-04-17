
namespace Tourtech.Models.Shared
{
    public class VideoSectionViewModel : ContentSectionViewModel
    {
        public VideoSectionViewModel(string url)
        {
            Url = url;
        }

        public string Url { get; private set; }
    }
}
