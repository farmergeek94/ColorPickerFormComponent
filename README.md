# ColorPickerFormComponent
This FormComponent will allow you to add the color picker from https://github.com/Simonwep/pickr to your widget and section properties for easy color selection.

# Instructions
## Example use

```
[EditingComponent(ColorPickerComponent.IDENTIFIER, Order = 29, Label = "{$HBS.Section.StylizedBoostrap.SectionBackground$}", Tooltip = "{$HBS.Section.StylizedBoostrap.SectionBackgroundTooltip$}")]
[EditingComponentProperty(nameof(ColorPickerComponentProperties.DefaultValue), "#FFFFFF")]
[EditingComponentProperty(nameof(ColorPickerComponentProperties.Placeholder), "rgba(---,---,---,0-1)")]
public string SectionBackground { get; set; }
```
![example image](https://github.com/farmergeek94/ColorPickerFormComponent/blob/master/Example.png?raw=true)

## Nuget Package
https://www.nuget.org/packages/HBS.ColorPickerFormComponent.Kentico.MVC/
```
Install-Package HBS.ColorPickerFormComponent.Kentico.MVC -Version 12.29.5
```

# Contributions, fixes and License
Feel free to Fork and submit pull requests to contribute.

You can submit bugs through the issue list and i will get to them as soon as i can, unless you want to fix it yourself and submit a pull request!

MIT Licensed. This is free to use and modify!  Just include the license file in the root of the project.
