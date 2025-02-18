using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper_Mark_1.TagHelpers
{
    [HtmlTargetElement("mytag")]
    public class MyCustomTagHelper : TagHelper
    {
        public string path { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.SetAttribute("href", path);
            output.Content.SetContent("Test");
        }
    }
}
