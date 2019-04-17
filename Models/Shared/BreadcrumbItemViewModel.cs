
namespace Tourtech.Models.Shared
{
    public class BreadcrumbItemViewModel
    {
        public BreadcrumbItemViewModel(string text, string url)
        {
            Text = text;
            Url = url;
        }

        public string Text { get; private set; }

        public string Url { get; private set; }
    }
}