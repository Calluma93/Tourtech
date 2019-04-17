
using Services.Models.Shared;

namespace Services.Models.Products
{
    public class VideoSectionModel : ContentSectionModel
    {
        public VideoSectionModel(string url)
        {
            Url = url;
        }

        public string Url { get; private set; }
    }
}
