using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace FontAwesome5Picker.Startup
{
    public class Composer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
           
            builder.ManifestFilters().Append<ManifestFilter>();
        }
    }
}
