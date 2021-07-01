﻿using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;
using UmbracoNineDemoSite.Core.Features.Shared.Content;

namespace UmbracoNineDemoSite.Core.Features.Page
{
    public class PageViewModel : SitePageBase, IHeadingPage
    {
        public PageViewModel(IPublishedContent content) : base(content) { }

        public string Heading => this.Content.Value<string>("heading");
    }
}