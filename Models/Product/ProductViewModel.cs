
using System.Collections.Generic;
using Tourtech.Models.Shared;

namespace Tourtech.Models.Product
{
    public class ProductViewModel : SubPageViewModel
    {
        public ProductViewModel(
            IEnumerable<ContentSectionViewModel> contentSections, IEnumerable<ImageViewModel> galleryImages,
            IEnumerable<string> overviewParagraphs, IEnumerable<string> features
        )
        {
            ContentSections = contentSections;
            GalleryImages = galleryImages;
            OverviewParagraphs = overviewParagraphs;
            Features = features;
        }

        public IEnumerable<ContentSectionViewModel> ContentSections { get; private set; }

        public IEnumerable<ImageViewModel> GalleryImages { get; private set; }

        public IEnumerable<string> OverviewParagraphs { get; private set; }

        public IEnumerable<string> Features { get; private set; }
    }
}