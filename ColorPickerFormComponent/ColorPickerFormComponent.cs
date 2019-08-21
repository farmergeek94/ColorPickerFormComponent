using Kentico.PageBuilder.Web.Mvc;
using HBS.ColorPickerFormComponent.Kentico.MVC;
using Kentico.Forms.Web.Mvc;

// Registers the Widget, pointing to the View that is actually compiled and located in the ColorPickerFormComponent.View project.
[assembly: RegisterFormComponent(ColorPickerComponent.IDENTIFIER, typeof(ColorPickerComponent), "Color Picker", Description = "Color Picker allowing you to select or convert any color value.", IconClass = "icon-palette")]

// FOR TESTING
// You can change the registration to point to a local View (non compiled) in order to debug.  
// This particular view is on my MVC Project, NOT my compiled ColorPickerFormComponent.View project
//[assembly: RegisterWidget("HBS.ColorPickerFormComponent", "Sample widget", typeof(ColorPickerFormComponentWidgetModel), customViewName: "Widgets/_ColorPickerFormComponent_Test")]
namespace HBS.ColorPickerFormComponent.Kentico.MVC
{
    public class ColorPickerComponent : FormComponent<ColorPickerComponentProperties, string>
    {
        public const string IDENTIFIER = "ColorPickerComponent";

        [BindableProperty]
        public string Value { get; set; }

        public override string GetValue()
        {
            return Value;
        }

        public override void SetValue(string value)
        {
            Value = value;
        }
    }
}