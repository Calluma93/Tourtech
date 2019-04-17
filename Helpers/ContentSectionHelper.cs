
using Services.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using Tourtech.Models.Shared;

namespace Tourtech.Helpers
{
    public static class ContentSectionHelper
    {
        private static ContentSectionViewModel mapContentSectionToViewModel(ContentSectionModel contentSection)
        {
            if(contentSection is HeadingSectionModel)
            {
                HeadingSectionModel headingSection = (HeadingSectionModel)contentSection;
                return new HeadingSectionViewModel((headingSection).Text);
            }
            if(contentSection is ParagraphSectionModel)
            {
                ParagraphSectionModel paragraphSection = (ParagraphSectionModel)contentSection;
                return new ParagraphSectionViewModel(paragraphSection.Text);
            }
            if(contentSection is ImageSectionModel)
            {
                ImageSectionModel imageSection = (ImageSectionModel)contentSection;
                return new ImageSectionViewModel(
                    ImageHelper.MapImageToViewModel(imageSection.Image)
                );
            }
            if (contentSection is VideoSectionModel)
            {
                VideoSectionModel videoSection = (VideoSectionModel)contentSection;
                return new VideoSectionViewModel(videoSection.Url);
            }
            if(contentSection is CompositeSectionModel)
            {
                CompositeSectionModel compositeSection = (CompositeSectionModel)contentSection;
                return new CompositeSectionViewModel(
                    compositeSection.Heading, compositeSection.Paragraphs,
                    ImageHelper.MapImageToViewModel(compositeSection.Image), compositeSection.ImageAlignment
                );
            }
            throw new Exception("Unknown ContentSectionModel type");
        }

        public static IEnumerable<ContentSectionViewModel> MapContentSectionsToViewModels(
            IEnumerable<ContentSectionModel> contentSections
        )
        {
            return contentSections.Select(a => mapContentSectionToViewModel(a));
        }
    }
}