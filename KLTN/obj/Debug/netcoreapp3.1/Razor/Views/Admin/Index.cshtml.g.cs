#pragma checksum "C:\Users\SONY\Downloads\KLTN_TNP\KLTN\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d04cfb25f200c840e4ed2faa58588afcfad3ea69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d04cfb25f200c840e4ed2faa58588afcfad3ea69", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e9222b1125e3c69520f20665dbb39fcef8068ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\SONY\Downloads\KLTN_TNP\KLTN\Views\Admin\Index.cshtml"
   Layout = "~/Views/Shared/_LayoutDashBoard.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"pd-ltr-20\">\r\n    <div class=\"card-box pd-20 height-100-p mb-30\">\r\n        <div class=\"row align-items-center\">\r\n            <div class=\"col-md-4\">\r\n                <img src=\"vendors/images/banner-img.png\"");
            BeginWriteAttribute("alt", " alt=\"", 273, "\"", 279, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
            <div class=""col-md-8"">
                <h4 class=""font-20 weight-500 mb-10 text-capitalize"">
                    Chào mừng trở lại
                    <div class=""weight-600 font-30 text-blue"">Admin</div>
                </h4>
                <p class=""font-18 max-width-600"">
                    Chúc một ngày tốt lành,<br />
                    Đây là trang dành cho người quản trị viên, dùng để thiết lập thêm, sửa, xóa cơ sở dữ liệu.....
                </p>
            </div>
        </div>
    </div>
</div>");
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
