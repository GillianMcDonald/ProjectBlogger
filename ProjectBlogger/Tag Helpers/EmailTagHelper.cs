using Microsoft.AspNetCore.Razor.TagHelpers;
using System;


namespace ProjectBlogger.Tag_Helpers
{
    public class EmailTagHelper :TagHelper
    {
        public string Address { get; set; }
        public string Content { get; set; }

        //building the html output when the tag is used.  
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //we want to create an email link so the output for the tag is a simple anchortag 
            output.TagName = "a";
            //also when the tag above is created we want to add attributes.  the following says when the href is created
            //we want the attributes to use mailto and the value of the address property
            output.Attributes.SetAttribute("href", "mailto:" + Address);
            //next, between the open and close tags i want to provide some content.  specify content property should be used
            output.Content.SetContent(Content);
        }
    }
}
