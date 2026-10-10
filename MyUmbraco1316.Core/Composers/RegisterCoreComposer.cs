using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace MyUmbraco1316.Core.Composers;

public class RegisterCoreComposer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        // Register Core services, notification handlers, and custom MVC bits here.
    }
}
