#pragma checksum "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "145606c354d366744b12292a1aa207cfccdb0147"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Account_MyAccount), @"mvc.1.0.view", @"/Areas/Admin/Views/Account/MyAccount.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Account/MyAccount.cshtml", typeof(AspNetCore.Areas_Admin_Views_Account_MyAccount))]
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
#line 1 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
using AutoClub.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"145606c354d366744b12292a1aa207cfccdb0147", @"/Areas/Admin/Views/Account/MyAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Account_MyAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AccountSettings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-2 edit-profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("90"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
  
    ViewData["Title"] = "MyAccount";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(146, 444, true);
            WriteLiteral(@"
<div class=""layout-px-spacing"">

    <div class=""row layout-spacing"">

        <!-- Content -->
        <div class=""col-xl-4 col-lg-6 col-md-5 col-sm-12 layout-top-spacing"">
            <div class=""user-profile layout-spacing"">
                <div class=""widget-content widget-content-area"">
                    <div class=""d-flex justify-content-between"">
                        <h3 class="""">Profile</h3>
                        ");
            EndContext();
            BeginContext(590, 422, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "145606c354d366744b12292a1aa207cfccdb01476054", async() => {
                BeginContext(690, 318, true);
                WriteLiteral(@" <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-edit-3""><path d=""M12 20h9""></path><path d=""M16.5 3.5a2.121 2.121 0 0 1 3 3L7 19l-4 1 1-4L16.5 3.5z""></path></svg>");
                EndContext();
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
            EndContext();
            BeginContext(1012, 111, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"text-center user-info\">\r\n                        ");
            EndContext();
            BeginContext(1123, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "145606c354d366744b12292a1aa207cfccdb01478370", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1133, "~/image/Users/", 1133, 14, true);
#line 21 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
AddHtmlAttributeValue("", 1147, Model.Image, 1147, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1185, 38, true);
            WriteLiteral("\r\n                        <p class=\"\">");
            EndContext();
            BeginContext(1224, 15, false);
#line 22 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
                               Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1239, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1241, 14, false);
#line 22 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
                                                Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1255, 772, true);
            WriteLiteral(@"</p>
                    </div>
                    <div class=""user-info-list"">

                        <div class="""">
                            <ul class=""contacts-block list-unstyled"" style=""max-width:290px"">
                                <li class=""contacts-block__item"">
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-coffee""><path d=""M18 8h1a4 4 0 0 1 0 8h-1""></path><path d=""M2 8h16v9a4 4 0 0 1-4 4H6a4 4 0 0 1-4-4V8z""></path><line x1=""6"" y1=""1"" x2=""6"" y2=""4""></line><line x1=""10"" y1=""1"" x2=""10"" y2=""4""></line><line x1=""14"" y1=""1"" x2=""14"" y2=""4""></line></svg> ");
            EndContext();
            BeginContext(2028, 13, false);
#line 29 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.Section);

#line default
#line hidden
            EndContext();
            BeginContext(2041, 466, true);
            WriteLiteral(@"
                                </li>
                                <li class=""contacts-block__item"">
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-map-pin""><path d=""M21 10c0 7-9 13-9 13s-9-6-9-13a9 9 0 0 1 18 0z""></path><circle cx=""12"" cy=""10"" r=""3""></circle></svg>");
            EndContext();
            BeginContext(2508, 14, false);
#line 32 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
                                                                                                                                                                                                                                                                                                                                                                 Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(2522, 146, true);
            WriteLiteral("\r\n                                </li>\r\n                                <li class=\"contacts-block__item\">\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2668, "\"", 2694, 2);
            WriteAttributeValue("", 2675, "mailto:", 2675, 7, true);
#line 35 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
WriteAttributeValue("", 2682, Model.Email, 2682, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2695, 355, true);
            WriteLiteral(@"><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-mail""><path d=""M4 4h16c1.1 0 2 .9 2 2v12c0 1.1-.9 2-2 2H4c-1.1 0-2-.9-2-2V6c0-1.1.9-2 2-2z""></path><polyline points=""22,6 12,13 2,6""></polyline></svg>");
            EndContext();
            BeginContext(3051, 11, false);
#line 35 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3062, 669, true);
            WriteLiteral(@"</a>
                                </li>
                                <li class=""contacts-block__item"">
                                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-phone""><path d=""M22 16.92v3a2 2 0 0 1-2.18 2 19.79 19.79 0 0 1-8.63-3.07 19.5 19.5 0 0 1-6-6 19.79 19.79 0 0 1-3.07-8.67A2 2 0 0 1 4.11 2h3a2 2 0 0 1 2 1.72 12.84 12.84 0 0 0 .7 2.81 2 2 0 0 1-.45 2.11L8.09 9.91a16 16 0 0 0 6 6l1.27-1.27a2 2 0 0 1 2.11-.45 12.84 12.84 0 0 0 2.81.7A2 2 0 0 1 22 16.92z""></path></svg> ");
            EndContext();
            BeginContext(3732, 11, false);
#line 38 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(3743, 170, true);
            WriteLiteral("\r\n                                </li>\r\n                                <li class=\"contacts-block__item\">\r\n                                    <ul class=\"list-inline\">\r\n");
            EndContext();
#line 42 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
                                         if (Model.FacebookLink != null)
                                        {

#line default
#line hidden
            BeginContext(4030, 204, true);
            WriteLiteral("                                            <li class=\"list-inline-item\">\r\n                                                <div class=\"social-icon\">\r\n                                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4234, "\"", 4260, 1);
#line 46 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
WriteAttributeValue("", 4241, Model.FacebookLink, 4241, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4261, 444, true);
            WriteLiteral(@" style=""line-height: 28px;""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-facebook""><path d=""M18 2h-3a5 5 0 0 0-5 5v3H7v4h3v8h4v-8h3l1-4h-4V7a1 1 0 0 1 1-1h3z""></path></svg></a>
                                                </div>
                                            </li>
");
            EndContext();
#line 49 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4748, 40, true);
            WriteLiteral("                                        ");
            EndContext();
#line 50 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
                                         if (Model.InstagramLink != null)
                                        {

#line default
#line hidden
            BeginContext(4866, 204, true);
            WriteLiteral("                                            <li class=\"list-inline-item\">\r\n                                                <div class=\"social-icon\">\r\n                                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5070, "\"", 5097, 1);
#line 54 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
WriteAttributeValue("", 5077, Model.InstagramLink, 5077, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5098, 541, true);
            WriteLiteral(@" style=""line-height: 28px;""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-instagram""><rect x=""2"" y=""2"" width=""20"" height=""20"" rx=""5"" ry=""5""></rect><path d=""M16 11.37A4 4 0 1 1 12.63 8 4 4 0 0 1 16 11.37z""></path><line x1=""17.5"" y1=""6.5"" x2=""17.51"" y2=""6.5""></line></svg></a>
                                                </div>
                                            </li>
");
            EndContext();
#line 57 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
                                        }

#line default
#line hidden
            BeginContext(5682, 40, true);
            WriteLiteral("                                        ");
            EndContext();
#line 58 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
                                         if (Model.TwitterLink != null)
                                        {

#line default
#line hidden
            BeginContext(5798, 204, true);
            WriteLiteral("                                            <li class=\"list-inline-item\">\r\n                                                <div class=\"social-icon\">\r\n                                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6002, "\"", 6027, 1);
#line 62 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
WriteAttributeValue("", 6009, Model.TwitterLink, 6009, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6028, 549, true);
            WriteLiteral(@" style=""line-height: 28px;""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-twitter""><path d=""M23 3a10.9 10.9 0 0 1-3.14 1.53 4.48 4.48 0 0 0-7.86 3v1A10.66 10.66 0 0 1 3 4s-4 9 5 13a11.64 11.64 0 0 1-7 2c9 5 20 0 20-11.5a4.5 4.5 0 0 0-.08-.83A7.72 7.72 0 0 0 23 3z""></path></svg></a>
                                                </div>
                                            </li>
");
            EndContext();
#line 65 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
                                        }

#line default
#line hidden
            BeginContext(6620, 40, true);
            WriteLiteral("                                        ");
            EndContext();
#line 66 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
                                         if (Model.LinkedinLink != null)
                                        {

#line default
#line hidden
            BeginContext(6737, 204, true);
            WriteLiteral("                                            <li class=\"list-inline-item\">\r\n                                                <div class=\"social-icon\">\r\n                                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6941, "\"", 6967, 1);
#line 70 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
WriteAttributeValue("", 6948, Model.LinkedinLink, 6948, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6968, 541, true);
            WriteLiteral(@" style=""line-height: 28px;""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-linkedin""><path d=""M16 8a6 6 0 0 1 6 6v7h-4v-7a2 2 0 0 0-2-2 2 2 0 0 0-2 2v7h-4v-7a6 6 0 0 1 6-6z""></path><rect x=""2"" y=""9"" width=""4"" height=""12""></rect><circle cx=""4"" cy=""4"" r=""2""></circle></svg></a>
                                                </div>
                                            </li>
");
            EndContext();
#line 73 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
                                        }

#line default
#line hidden
            BeginContext(7552, 515, true);
            WriteLiteral(@"                                    </ul>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""col-xl-8 col-lg-6 col-md-7 col-sm-12 layout-top-spacing"">
            <div class=""bio layout-spacing "">
                <div class=""widget-content widget-content-area"">
                    <h3 class="""">Bio</h3>
                    <p class=""py-5 px-3"">");
            EndContext();
            BeginContext(8068, 17, false);
#line 87 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\Account\MyAccount.cshtml"
                                    Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(8085, 88, true);
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
