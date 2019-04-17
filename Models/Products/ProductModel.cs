using Services.Models.Shared;
using System.Collections.Generic;

namespace Services.Models.Products
{
    public class ProductModel
    {
        public ProductModel(
            string name, string title, string imageRelativeUrl, string bannerImageRelativeUrl,
            IEnumerable<ContentSectionModel> contentSections, IEnumerable<ImageModel> galleryImages,
            IEnumerable<string> overviewParagraphs, IEnumerable<string> features,
            MetaDataModel metaData
        )
        {
            Name = name;
            Title = title;
            ImageRelativeUrl = imageRelativeUrl;
            ContentSections = contentSections;
            GalleryImages = galleryImages;
            OverviewParagraphs = overviewParagraphs;
            Features = features;
            BannerImageRelativeUrl = bannerImageRelativeUrl;
            MetaData = metaData;
        }

        public string Name { get; private set; }

        public string Title { get; private set; }

        public string ImageRelativeUrl { get; private set; }

        public string BannerImageRelativeUrl { get; private set; }

        public IEnumerable<ContentSectionModel> ContentSections { get; private set; }

        public IEnumerable<ImageModel> GalleryImages { get; private set; }

        public IEnumerable<string> OverviewParagraphs { get; private set; }

        public IEnumerable<string> Features { get; private set; }

        public MetaDataModel MetaData { get; private set; }
    }
}
