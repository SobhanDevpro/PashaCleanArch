#pragma checksum "C:\Users\sobhan\Desktop\Pasha\PashaMarket\PashaMarket.web\Areas\User\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0e6a42ff4c37c614ad46c93858e08788ef62c8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Home_Dashboard), @"mvc.1.0.view", @"/Areas/User/Views/Home/Dashboard.cshtml")]
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
#line 1 "C:\Users\sobhan\Desktop\Pasha\PashaMarket\PashaMarket.web\Areas\User\Views\_ViewImports.cshtml"
using PashaMarket.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sobhan\Desktop\Pasha\PashaMarket\PashaMarket.web\Areas\User\Views\_ViewImports.cshtml"
using PashaMarket.web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e6a42ff4c37c614ad46c93858e08788ef62c8d", @"/Areas/User/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb9ce2cdd4f3736d01ea6ad008ff5c612335c704", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link-spoiler-edit btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\sobhan\Desktop\Pasha\PashaMarket\PashaMarket.web\Areas\User\Views\Home\Dashboard.cshtml"
  
    ViewData["Title"] = "داشبورد";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-9 col-md-9 col-xs-12 pl"">
    <div class=""profile-content"">
        <div class=""profile-stats"">
            <table class=""table table-profile"">
                <tbody>
                    <tr>
                        <td class=""w-50"">
                            <div class=""title"">نام و نام خانوادگی:</div>
                            <div class=""value"">");
#nullable restore
#line 14 "C:\Users\sobhan\Desktop\Pasha\PashaMarket\PashaMarket.web\Areas\User\Views\Home\Dashboard.cshtml"
                                          Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </td>
                        <td>
                            <div class=""title"">پست الکترونیک :</div>
                            <div class=""value"">info@digismart.com</div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class=""title"">شماره تلفن همراه:</div>
                            <div class=""value"">*******0991</div>
                        </td>
                        <td>
                            <div class=""title"">تاریخ عضویت:</div>
                            <div class=""value"">۱۳۹۹/۰۱/۱۲</div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <div class=""title""> دریافت خبرنامه :</div>
                            <div class=""value"">بله</div>
                        </td>
                        <td>
                            <div class=""title""> کد ملی :</div>");
            WriteLiteral(@"
                            <div class=""value"">-</div>
                        </td>
                    </tr>
                </tbody>
            </table>
            <div class=""profile"">
                <ul class=""mb-0"">
                    <li class=""profile-item"">
                        <div class=""title"">نام و نام خانوادگی:</div>
                        <div class=""value"">");
#nullable restore
#line 47 "C:\Users\sobhan\Desktop\Pasha\PashaMarket\PashaMarket.web\Areas\User\Views\Home\Dashboard.cshtml"
                                      Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </li>
                    <li class=""profile-item"">
                        <div class=""title"">پست الکترونیک :</div>
                        <div class=""value"">info@digismart.com</div>
                    </li>
                    <li class=""profile-item"">
                        <div class=""title"">شماره تلفن همراه:</div>
                        <div class=""value"">*******0991</div>
                    </li>
                    <li class=""profile-item"">
                        <div class=""title"">تاریخ عضویت:</div>
                        <div class=""value"">۱۳۹۹/۰۱/۱۲</div>
                    </li>
                    <li class=""profile-item"">
                        <div class=""title""> دریافت خبرنامه :</div>
                        <div class=""value"">بله</div>
                    </li>
                    <li class=""profile-item"">
                        <div class=""title""> کد ملی :</div>
                        <div class=""value"">-</div>
                    </l");
            WriteLiteral("i>\r\n                </ul>\r\n            </div>\r\n            <div class=\"profile-edit-action\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0e6a42ff4c37c614ad46c93858e08788ef62c8d8363", async() => {
                WriteLiteral("ویرایش اطلاعات");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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