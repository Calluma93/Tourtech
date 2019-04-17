
using Services.Models.Shared;
using System.Collections.Generic;

namespace Tourtech.Models.Shared
{
    public class CompositeSectionViewModel : ContentSectionViewModel
    {
        public CompositeSectionViewModel(
            string heading, IEnumerable<string> paragraphs, ImageViewModel image, RelativeDirection imageAlignment
        )
        {
            Heading = heading;
            Paragraphs = paragraphs;
            Image = image;
            ImageAlignment = imageAlignment;
        }

        public string Heading
        {
            get; private set;
        }

        public IEnumerable<string> Paragraphs
        {
            get; private set;
        }

        public ImageViewModel Image
        {
            get; private set;
        }

        public RelativeDirection ImageAlignment
        {
            get; private set;
        }
    }
}