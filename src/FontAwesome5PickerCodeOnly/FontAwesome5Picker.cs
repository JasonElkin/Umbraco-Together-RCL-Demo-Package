
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.PropertyEditors;

namespace FontAwesome5PickerCodeOnly
{
    [DataEditor(
    alias: "fontAwesome5Picker",
    name: "Font Awesome 5 Icon Picker",
    view: "/fontawesome-5-picker/edit.html",
    Group = "Icons",
    Icon = "icon-flag-alt")]
    public class FontAwesome5Picker : DataEditor
    {
        public FontAwesome5Picker(IDataValueEditorFactory dataValueEditorFactory) : base(dataValueEditorFactory)
        { }
    }
}
