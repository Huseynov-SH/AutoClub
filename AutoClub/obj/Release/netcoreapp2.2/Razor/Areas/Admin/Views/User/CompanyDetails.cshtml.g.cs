#pragma checksum "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34d6706ccc173cee66d8ed1631a93e9dcc439547"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_CompanyDetails), @"mvc.1.0.view", @"/Areas/Admin/Views/User/CompanyDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/User/CompanyDetails.cshtml", typeof(AspNetCore.Areas_Admin_Views_User_CompanyDetails))]
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
#line 1 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
using AutoClub.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34d6706ccc173cee66d8ed1631a93e9dcc439547", @"/Areas/Admin/Views/User/CompanyDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_CompanyDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Company", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
  
    ViewData["Title"] = "CompanyDetails";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(151, 810, true);
            WriteLiteral(@"
<div class=""row justify-content-md-center my-5"">
    <div class=""col-lg-10 layout-spacing"">
        <div class=""statbox widget box box-shadow"">
            <div class=""widget-content widget-content-area"">
                <div class=""row justify-content-md-center"">
                    <div class=""col-lg-8 layout-spacing"">
                        <div class=""widget-header"">
                            <div class=""row"">
                                <div class=""col-xl-12 col-md-12 col-sm-12 col-12 mb-4 text-center"">
                                    <h4>Company Logo</h4>
                                </div>
                            </div>
                        </div>
                        <div class=""avatar avatar-xl row justify-content-around"">
                            ");
            EndContext();
            BeginContext(961, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "34d6706ccc173cee66d8ed1631a93e9dcc4395476151", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 971, "~/image/Users/", 971, 14, true);
#line 22 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
AddHtmlAttributeValue("", 985, Model.Image, 985, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1029, 920, true);
            WriteLiteral(@"
                        </div>
                        <div class=""widget-header"">
                            <div class=""row"">
                                <div class=""col-xl-12 col-md-12 col-sm-12 col-12 mt-5 mb-3 text-center"">
                                    <h4>Company Details</h4>
                                </div>
                            </div>
                        </div>
                        <div class=""table-responsive"">
                            <table class=""table mb-2"">
                                <thead>
                                    <tr>
                                        <th class=""text-center"">Company Name</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td class=""text-center"">");
            EndContext();
            BeginContext(1950, 14, false);
#line 40 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
                                                           Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1964, 748, true);
            WriteLiteral(@"</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <div class=""table-responsive"">
                            <table class=""table mb-2"">
                                <thead>
                                    <tr>
                                        <th class=""text-center"">FirstName</th>
                                        <th class=""text-center"">LastName</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td class=""text-center"">");
            EndContext();
            BeginContext(2713, 15, false);
#line 55 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
                                                           Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2728, 71, true);
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\">");
            EndContext();
            BeginContext(2800, 14, false);
#line 56 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
                                                           Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2814, 665, true);
            WriteLiteral(@"</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <div class=""table-responsive"">
                            <table class=""table mb-2"">
                                <thead>
                                    <tr>
                                        <th class=""text-center"">Email</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td class=""text-center"">");
            EndContext();
            BeginContext(3480, 11, false);
#line 70 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
                                                           Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3491, 1111, true);
            WriteLiteral(@"</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <div class=""widget-header"">
                            <div class=""row"">
                                <div class=""col-xl-12 col-md-12 col-sm-12 col-12 mt-5 mb-3 text-center"">
                                    <h4>Contact</h4>
                                </div>
                            </div>
                        </div>
                        <div class=""table-responsive"">
                            <table class=""table mb-2"">
                                <thead>
                                    <tr>
                                        <th class=""text-center"">Address</th>
                                        <th class=""text-center"">Phone</th>
                                    </tr>
                                </thead>
                                <tbody>
                   ");
            WriteLiteral("                 <tr>\r\n                                        <td class=\"text-center\">");
            EndContext();
            BeginContext(4603, 14, false);
#line 92 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
                                                           Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(4617, 71, true);
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\">");
            EndContext();
            BeginContext(4689, 11, false);
#line 93 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
                                                           Write(Model.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(4700, 669, true);
            WriteLiteral(@"</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class=""col-lg-11 layout-spacing text-center"">
                        <div class=""widget-header"">
                            <div class=""row"">
                                <div class=""col-xl-12 col-md-12 col-sm-12 col-12 mt-3 mb-3 text-center"">
                                    <h4>Company Description</h4>
                                </div>
                            </div>
                        </div>
                        <p>");
            EndContext();
            BeginContext(5370, 17, false);
#line 107 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
                      Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(5387, 460, true);
            WriteLiteral(@"</p>
                    </div>
                    <div class=""col-lg-8 layout-spacing"">
                        <div class=""widget-header"">
                            <div class=""row"">
                                <div class=""col-xl-12 col-md-12 col-sm-12 col-12 mt-5 mb-3 text-center"">
                                    <h4>Social</h4>
                                </div>
                            </div>
                        </div>
");
            EndContext();
#line 117 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
                         if (Model.FacebookLink != null)
                        {

#line default
#line hidden
            BeginContext(5932, 548, true);
            WriteLiteral(@"                            <div class=""table-responsive"">
                                <table class=""table mb-2"">
                                    <thead>
                                        <tr>
                                            <th class=""text-center"">Facebook</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td class=""text-center""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6480, "\"", 6506, 1);
#line 128 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
WriteAttributeValue("", 6487, Model.FacebookLink, 6487, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6507, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(6509, 18, false);
#line 128 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
                                                                                             Write(Model.FacebookLink);

#line default
#line hidden
            EndContext();
            BeginContext(6527, 182, true);
            WriteLiteral("</a></td>\r\n                                        </tr>\r\n                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n");
            EndContext();
#line 133 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
                        }

#line default
#line hidden
            BeginContext(6736, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 134 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
                         if (Model.InstagramLink != null)
                        {

#line default
#line hidden
            BeginContext(6822, 549, true);
            WriteLiteral(@"                            <div class=""table-responsive"">
                                <table class=""table mb-2"">
                                    <thead>
                                        <tr>
                                            <th class=""text-center"">Insdagram</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td class=""text-center""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7371, "\"", 7398, 1);
#line 145 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
WriteAttributeValue("", 7378, Model.InstagramLink, 7378, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7399, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(7401, 19, false);
#line 145 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
                                                                                              Write(Model.InstagramLink);

#line default
#line hidden
            EndContext();
            BeginContext(7420, 182, true);
            WriteLiteral("</a></td>\r\n                                        </tr>\r\n                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n");
            EndContext();
#line 150 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
                        }

#line default
#line hidden
            BeginContext(7629, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 151 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
                         if (Model.TwitterLink != null)
                        {

#line default
#line hidden
            BeginContext(7713, 547, true);
            WriteLiteral(@"                            <div class=""table-responsive"">
                                <table class=""table mb-2"">
                                    <thead>
                                        <tr>
                                            <th class=""text-center"">Twitter</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td class=""text-center""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8260, "\"", 8285, 1);
#line 162 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
WriteAttributeValue("", 8267, Model.TwitterLink, 8267, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8286, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(8288, 17, false);
#line 162 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
                                                                                            Write(Model.TwitterLink);

#line default
#line hidden
            EndContext();
            BeginContext(8305, 182, true);
            WriteLiteral("</a></td>\r\n                                        </tr>\r\n                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n");
            EndContext();
#line 167 "D:\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\CompanyDetails.cshtml"
                        }

#line default
#line hidden
            BeginContext(8514, 93, true);
            WriteLiteral("                    </div>\r\n                    <div class=\"col-8\">\r\n                        ");
            EndContext();
            BeginContext(8607, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34d6706ccc173cee66d8ed1631a93e9dcc43954722625", async() => {
                BeginContext(8687, 7, true);
                WriteLiteral("Go Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8698, 108, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
