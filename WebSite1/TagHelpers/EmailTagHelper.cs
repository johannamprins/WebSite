using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebSite1.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string Address { get; set; }
        public string LinkText { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailuto:" + Address);
            output.Content.SetContent(LinkText);
        }
    }
}
