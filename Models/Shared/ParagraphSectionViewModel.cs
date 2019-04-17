
namespace Tourtech.Models.Shared
{
    public class ParagraphSectionViewModel : ContentSectionViewModel
    {
        public ParagraphSectionViewModel(string text)
        {
            Text = text;
        }

        public string Text { get; private set; }
    }
}
