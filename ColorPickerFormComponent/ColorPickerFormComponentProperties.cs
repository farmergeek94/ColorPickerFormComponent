using CMS.DataEngine;
using Kentico.Forms.Web.Mvc;

namespace HBS.ColorPickerFormComponent.Kentico.MVC
{
    public class ColorPickerComponentProperties : FormComponentProperties<string>
    {
        [DefaultValueEditingComponent("ColorPickerComponent", DefaultValue = "rgba(0,0,0,0.7)")]
        public override string DefaultValue
        {
            get;
            set;
        }

        // Initializes a new instance of the RgbInputComponentProperties class and configures the underlying database field
        public ColorPickerComponentProperties()
            : base(FieldDataType.Text)
        {
        }
    }
}
