#pragma checksum "/Users/danielware/Desktop/Mad_Libs.Solution/Mad_Libs/Views/Home/Story.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f7d3dd0788edd4e83281b84aa8177bcad30c22a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Story), @"mvc.1.0.view", @"/Views/Home/Story.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f7d3dd0788edd4e83281b84aa8177bcad30c22a", @"/Views/Home/Story.cshtml")]
    public class Views_Home_Story : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("m-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html>\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f7d3dd0788edd4e83281b84aa8177bcad30c22a3001", async() => {
                WriteLiteral("\n    <title>Mad Lib</title>\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css\" integrity=\"sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk\" crossorigin=\"anonymous\">\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f7d3dd0788edd4e83281b84aa8177bcad30c22a4206", async() => {
                WriteLiteral("\n    <div id=\"story\">\n        <h1>A fantastical adventure</h1>\n        <p>\n          One day, <strong>");
#nullable restore
#line 11 "/Users/danielware/Desktop/Mad_Libs.Solution/Mad_Libs/Views/Home/Story.cshtml"
                      Write(Model.Person1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong> and\n          <strong>");
#nullable restore
#line 12 "/Users/danielware/Desktop/Mad_Libs.Solution/Mad_Libs/Views/Home/Story.cshtml"
             Write(Model.Person2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong> were walking through the woods, when\n          suddenly a giant <strong>");
#nullable restore
#line 13 "/Users/danielware/Desktop/Mad_Libs.Solution/Mad_Libs/Views/Home/Story.cshtml"
                              Write(Model.Animal);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong> appeared. ");
#nullable restore
#line 13 "/Users/danielware/Desktop/Mad_Libs.Solution/Mad_Libs/Views/Home/Story.cshtml"
                                                               Write(Model.Exclamation);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n          , <strong>");
#nullable restore
#line 14 "/Users/danielware/Desktop/Mad_Libs.Solution/Mad_Libs/Views/Home/Story.cshtml"
               Write(Model.Person1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong> cried. The two of them\n          <strong>");
#nullable restore
#line 15 "/Users/danielware/Desktop/Mad_Libs.Solution/Mad_Libs/Views/Home/Story.cshtml"
             Write(Model.Verb);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong> as quickly possible, and when they were\n          safe, <strong>");
#nullable restore
#line 16 "/Users/danielware/Desktop/Mad_Libs.Solution/Mad_Libs/Views/Home/Story.cshtml"
                   Write(Model.Person1);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong> and\n          <strong>");
#nullable restore
#line 17 "/Users/danielware/Desktop/Mad_Libs.Solution/Mad_Libs/Views/Home/Story.cshtml"
             Write(Model.Person2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong> gave each other a giant\n          <strong>");
#nullable restore
#line 18 "/Users/danielware/Desktop/Mad_Libs.Solution/Mad_Libs/Views/Home/Story.cshtml"
             Write(Model.Noun);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>.\n        </p>\n      </div>\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
