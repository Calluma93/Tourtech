
namespace Tourtech.Models.Shared
{
    public class HeadingSectionViewModel : ContentSectionViewModel
    {
        public HeadingSectionViewModel(string text)
        {
            Text = text;
        }

        public string Text { get; private set; }
    }
}
