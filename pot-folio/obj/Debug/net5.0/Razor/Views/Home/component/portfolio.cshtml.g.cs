#pragma checksum "F:\pro-portfolio\pot-folio\Views\Home\component\portfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25843450710cb1e2207dd996edd99fbfe257fa52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_component_portfolio), @"mvc.1.0.view", @"/Views/Home/component/portfolio.cshtml")]
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
#nullable restore
#line 1 "F:\pro-portfolio\pot-folio\Views\_ViewImports.cshtml"
using pot_folio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\pro-portfolio\pot-folio\Views\_ViewImports.cshtml"
using pot_folio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25843450710cb1e2207dd996edd99fbfe257fa52", @"/Views/Home/component/portfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"180724edb54378ba61f21c6296451b522fa3b63a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_component_portfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<portfoliomodel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "download", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "downloadimg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "F:\pro-portfolio\pot-folio\Views\Home\component\portfolio.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-12 portfolio-wrap\">\r\n        <div class=\"row no-gutters align-items-center\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 188, "\"", 213, 2);
            WriteAttributeValue("", 195, "images/", 195, 7, true);
#nullable restore
#line 8 "F:\pro-portfolio\pot-folio\Views\Home\component\portfolio.cshtml"
WriteAttributeValue("", 202, item.image, 202, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-md-6 img image-popup js-fullheight d-flex align-items-center justify-content-center\"");
            BeginWriteAttribute("style", " style=\"", 310, "\"", 360, 4);
            WriteAttributeValue("", 318, "background-image:", 318, 17, true);
            WriteAttributeValue(" ", 335, "url(images/", 336, 12, true);
#nullable restore
#line 8 "F:\pro-portfolio\pot-folio\Views\Home\component\portfolio.cshtml"
WriteAttributeValue("", 347, item.image, 347, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 358, ");", 358, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""icon d-flex align-items-center justify-content-center"">
                    <span class=""fa fa-expand""></span>
                </div>
            </a>
            <div class=""col-md-6"">
                <div class=""text pt-5 pl-0 px-lg-5 pl-md-4 ftco-animate"">
                    <div class=""px-4 px-lg-4"">
                        <div class=""desc"">
                            <div class=""top"">
                                <span class=""subheading"">Portrait</span>
                                <h2 class=""mb-4"">
                                    <a href=""gallery.html"">");
#nullable restore
#line 20 "F:\pro-portfolio\pot-folio\Views\Home\component\portfolio.cshtml"
                                                      Write(item.subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h2>\r\n                            </div>\r\n                            <div class=\"absolute\">\r\n                                <p>");
#nullable restore
#line 24 "F:\pro-portfolio\pot-folio\Views\Home\component\portfolio.cshtml"
                              Write(item.Describtion);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n                            </div>\r\n                      \r\n                            <p>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25843450710cb1e2207dd996edd99fbfe257fa526880", async() => {
                WriteLiteral("Download");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-image", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "F:\pro-portfolio\pot-folio\Views\Home\component\portfolio.cshtml"
                                                                                           WriteLiteral(item.image);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["image"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-image", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["image"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 36 "F:\pro-portfolio\pot-folio\Views\Home\component\portfolio.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<portfoliomodel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
