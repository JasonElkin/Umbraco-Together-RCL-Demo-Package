using System.IO;
using System.Reflection;

namespace FontAwesome5Picker.Startup
{
    public class ManifestReader
    {
        public static string ReadManifest()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "FontAwesome5Picker.package.manifest";

            using Stream stream = assembly.GetManifestResourceStream(resourceName);
            using StreamReader reader = new(stream);
            string result = reader.ReadToEnd();

            return result;
        }
    }
}
