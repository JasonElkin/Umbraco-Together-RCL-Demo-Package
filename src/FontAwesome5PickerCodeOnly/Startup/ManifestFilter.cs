﻿using System.Collections.Generic;
using Umbraco.Cms.Core.Manifest;

namespace FontAwesome5Picker.Startup
{
    public class ManifestFilter : IManifestFilter
    {
        void IManifestFilter.Filter(List<PackageManifest> manifests)
        {

            var manifest = new PackageManifest() { 
                PackageName = "Font Awesome 5 Picker",
                Scripts = new string[] { "/fontawesome-5-picker/all.js" }
            };

            manifests.Add(manifest);
        }
    }
}
