using Microsoft.AspNetCore.Razor.TagHelpers;

namespace StoreApp.InfraStructure.TagHelpers
{
    [HtmlTargetElement("table")]
    public class TableTagHelpers : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class","table table-hover table-striped");
        }
    }
}