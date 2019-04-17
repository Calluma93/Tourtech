
using Services.Models.Shared;
using System.Collections.Generic;

namespace Services.Models.Products
{
    public class CompositeSectionModel : ContentSectionModel
    {
        public CompositeSectionModel(string heading, IEnumerable<string> paragraphs, ImageModel image, RelativeDirection imageAlignment)
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

        public ImageModel Image
        {
            get; private set;
        }

        public RelativeDirection ImageAlignment
        {
            get; private set;
        }
    }
}