
using Services.Models.Shared;
using System.Collections.Generic;

namespace Services.Models.Products
{
    public class CategoryModel
    {
        public CategoryModel(
            string name, string title, string imageRelativeUrl, string bannerImageRelativeUrl, bool comingSoon,
            IEnumerable<ProductModel> products, IEnumerable<ContentSectionModel> contentSections,
            MetaDataModel metaData
        ) {
            Name = name;
            Title = title;
            ImageRelativeUrl = imageRelativeUrl;
            ComingSoon = comingSoon;
            Products = products;
            ContentSections = contentSections;
            BannerImageRelativeUrl = bannerImageRelativeUrl;
            MetaData = metaData;
        }

        public string Name { get; private set; }

        public string Title { get; private set; }

        public string ImageRelativeUrl { get; private set; }

        public string BannerImageRelativeUrl { get; private set; }

        public bool ComingSoon { get; private set; }

        public IEnumerable<ProductModel> Products { get; private set; }

        public IEnumerable<ContentSectionModel> ContentSections { get; private set; }

        public MetaDataModel MetaData { get; private set; }
    }
}
