#pragma checksum "C:\Users\SONY\Downloads\KLTN_TNP\KLTN\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b77217c7342f203b065e187e6a21401b45bcd876"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\SONY\Downloads\KLTN_TNP\KLTN\Views\_ViewImports.cshtml"
using ProjectKLTN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SONY\Downloads\KLTN_TNP\KLTN\Views\_ViewImports.cshtml"
using ProjectKLTN.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SONY\Downloads\KLTN_TNP\KLTN\Views\_ViewImports.cshtml"
using ProjectKLTN.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SONY\Downloads\KLTN_TNP\KLTN\Views\_ViewImports.cshtml"
using ProjectKLTN.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b77217c7342f203b065e187e6a21401b45bcd876", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e9222b1125e3c69520f20665dbb39fcef8068ee", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<!--================Hero Banner Area Start =================-->
<section class=""hero-banner d-flex align-items-center"">
    <div class=""container text-center"">
        <h2>About</h2>
        <nav aria-label=""breadcrumb"" class=""banner-breadcrumb"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b77217c7342f203b065e187e6a21401b45bcd8764315", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                <li class=""breadcrumb-item active"" aria-current=""page"">About</li>
            </ol>
        </nav>
    </div>
</section>
<!--================About  Area =================-->
<section class=""about-area area-padding-bottom"">
    <div class=""container"">
        <div class=""row align-items-center"">
");
#nullable restore
#line 18 "C:\Users\SONY\Downloads\KLTN_TNP\KLTN\Views\About\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-6\">\r\n                    <div class=\"area-heading\">\r\n                        <h4>");
#nullable restore
#line 22 "C:\Users\SONY\Downloads\KLTN_TNP\KLTN\Views\About\Index.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <h6>");
#nullable restore
#line 23 "C:\Users\SONY\Downloads\KLTN_TNP\KLTN\Views\About\Index.cshtml"
                       Write(item.ShortContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <p>");
#nullable restore
#line 24 "C:\Users\SONY\Downloads\KLTN_TNP\KLTN\Views\About\Index.cshtml"
                      Write(item.FullContent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6 col-lg-6"">
                            <div class=""single-about"">
                                <div class=""about-icon"">
                                    <i class=""ti-thought""></i>
                                </div>
                                <div class=""single-about-content"">
                                    <h5>Cloud Compatibility</h5>
                                    <p>There earth face earth behold. She stars made void two given and also our own grass days. Greater </p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-6 col-lg-6"">
                            <div class=""single-about"">
                                <div class=""about-icon"">
                                    <i class=""ti-truck""></i>
                                </div>
                  ");
            WriteLiteral(@"              <div class=""single-about-content"">
                                    <h5>On Time Delivery</h5>
                                    <p>There earth face earth behold. She stars made void two given and also our own grass days. Greater </p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 51 "C:\Users\SONY\Downloads\KLTN_TNP\KLTN\Views\About\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; }
    }
}
#pragma warning restore 1591
