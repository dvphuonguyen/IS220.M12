#pragma checksum "D:\__Nam3_HK1\OnThiFramwork\OnThi1\2021_QuanLyThietBi\2021_QuanLyThietBi\Views\NhanVien\LietKeSL.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c44bfc7235dc618ea1942a7e4b220d1f81916fd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_LietKeSL), @"mvc.1.0.view", @"/Views/NhanVien/LietKeSL.cshtml")]
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
#line 1 "D:\__Nam3_HK1\OnThiFramwork\OnThi1\2021_QuanLyThietBi\2021_QuanLyThietBi\Views\_ViewImports.cshtml"
using _2021_QuanLyThietBi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\__Nam3_HK1\OnThiFramwork\OnThi1\2021_QuanLyThietBi\2021_QuanLyThietBi\Views\_ViewImports.cshtml"
using _2021_QuanLyThietBi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c44bfc7235dc618ea1942a7e4b220d1f81916fd1", @"/Views/NhanVien/LietKeSL.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b147f1d62ba154720bab2dfc1c3168aae4fea9f", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_LietKeSL : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<object>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\__Nam3_HK1\OnThiFramwork\OnThi1\2021_QuanLyThietBi\2021_QuanLyThietBi\Views\NhanVien\LietKeSL.cshtml"
  
    ViewData["Title"] = "LietKeSL";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>LietKeSL</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c44bfc7235dc618ea1942a7e4b220d1f81916fd13773", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>T??n Nh??n Vi??n</th>\r\n            <th>S??? ??i???n Tho???i</th>\r\n            <th>S??? L???n S???a</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "D:\__Nam3_HK1\OnThiFramwork\OnThi1\2021_QuanLyThietBi\2021_QuanLyThietBi\Views\NhanVien\LietKeSL.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "D:\__Nam3_HK1\OnThiFramwork\OnThi1\2021_QuanLyThietBi\2021_QuanLyThietBi\Views\NhanVien\LietKeSL.cshtml"
           Write(item.GetType().GetProperty("TenNhanVien").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "D:\__Nam3_HK1\OnThiFramwork\OnThi1\2021_QuanLyThietBi\2021_QuanLyThietBi\Views\NhanVien\LietKeSL.cshtml"
           Write(item.GetType().GetProperty("SoDienThoai").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "D:\__Nam3_HK1\OnThiFramwork\OnThi1\2021_QuanLyThietBi\2021_QuanLyThietBi\Views\NhanVien\LietKeSL.cshtml"
           Write(item.GetType().GetProperty("SoLanSua").GetValue(item, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "D:\__Nam3_HK1\OnThiFramwork\OnThi1\2021_QuanLyThietBi\2021_QuanLyThietBi\Views\NhanVien\LietKeSL.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 36 "D:\__Nam3_HK1\OnThiFramwork\OnThi1\2021_QuanLyThietBi\2021_QuanLyThietBi\Views\NhanVien\LietKeSL.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 37 "D:\__Nam3_HK1\OnThiFramwork\OnThi1\2021_QuanLyThietBi\2021_QuanLyThietBi\Views\NhanVien\LietKeSL.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 40 "D:\__Nam3_HK1\OnThiFramwork\OnThi1\2021_QuanLyThietBi\2021_QuanLyThietBi\Views\NhanVien\LietKeSL.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<object>> Html { get; private set; }
    }
}
#pragma warning restore 1591
