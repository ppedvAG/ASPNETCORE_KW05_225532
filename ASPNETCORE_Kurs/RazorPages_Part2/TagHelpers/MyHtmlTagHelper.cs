using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPages_Part2.Models;

namespace RazorPages_Part2.TagHelpers
{
    public static class MyHtmlTagHelper
    {
        public static IHtmlContent HelloWordHtmlString(this IHtmlHelper htmlHelper)
            => new HtmlString("<strong>Hello World </strong>");

        public static string HelloWorldString(this IHtmlHelper htmlHelper)
            => "<strong>Hello World</strong>";

        public static IHtmlContent HelloWordToPerson(this IHtmlHelper htmlHelper, string name)
        {
            //<span>Hello, Asterix!</span>
            var span = new TagBuilder("span");

            span.InnerHtml.Append("Hello " + name + "!");

            // <br/>
            var br = new TagBuilder("br")
            {
                TagRenderMode = TagRenderMode.SelfClosing,
            };

            string result = string.Empty;

            using (StringWriter writer = new StringWriter())
            {
                span.WriteTo(writer, System.Text.Encodings.Web.HtmlEncoder.Default);
                br.WriteTo(writer, System.Text.Encodings.Web.HtmlEncoder.Default);
                result = writer.ToString();
            }
            return new HtmlString(result);
        }

        // <summary>
        /// Mit Paramter
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IHtmlContent HelloWordWithComplexObject(this IHtmlHelper htmlHelper, MyPerson myPersonObject)
        {
            //<span>Hello, Asterix!</span>
            var span = new TagBuilder("span");
            span.InnerHtml.Append("Hello, " + myPersonObject.FirstName + " - " + myPersonObject.LastName + "!");

            //<br/>
            var br = new TagBuilder("br")
            {
                TagRenderMode = TagRenderMode.SelfClosing,
            };

            string result = string.Empty;

            using (var writer = new StringWriter())
            {
                span.WriteTo(writer, System.Text.Encodings.Web.HtmlEncoder.Default);
                br.WriteTo(writer, System.Text.Encodings.Web.HtmlEncoder.Default);

                result = writer.ToString();
            }

            return new HtmlString(result);
        }
    }



}
