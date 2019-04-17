using Services.Models.Shared;

namespace Services.Models.PageContent
{
    public class PageModel
    {
        public PageModel(string mainHeading, MetaDataModel metaData)
        {
            MainHeading = mainHeading;
            MetaData = metaData;
        }

        public string MainHeading { get; private set; }

        public MetaDataModel MetaData { get; private set; }
    }
}
