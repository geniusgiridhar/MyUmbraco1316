using Umbraco.Cms.Core.Models.PublishedContent;

namespace MyUmbraco1316.Models.ViewModels.Pages;

public class PageViewModelBase
{
    public required IPublishedContent Content { get; init; }
}
