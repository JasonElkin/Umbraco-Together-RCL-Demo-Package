using System.Collections.Generic;
using Umbraco.Cms.Core.Manifest;

namespace FontAwesome5Picker.Startup
{
    public class ManifestFilter : IManifestFilter
    {
        private readonly IManifestParser parser;

        public ManifestFilter(IManifestParser parser)
        {
            this.parser = parser;
        }

        void IManifestFilter.Filter(List<PackageManifest> manifests)
        {
            var manifestJson = ManifestReader.ReadManifest();
            var manifest = parser.ParseManifest(manifestJson);
            manifest.PackageName = "Font Awesome 5 Picker";

            manifests.Add(manifest);
        }
    }
}
