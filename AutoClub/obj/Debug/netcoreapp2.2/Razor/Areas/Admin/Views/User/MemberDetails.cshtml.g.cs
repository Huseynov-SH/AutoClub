#pragma checksum "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18913b32a56c3cdd6c02134ed382a5f59acbc0d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_MemberDetails), @"mvc.1.0.view", @"/Areas/Admin/Views/User/MemberDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/User/MemberDetails.cshtml", typeof(AspNetCore.Areas_Admin_Views_User_MemberDetails))]
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
#line 1 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
using AutoClub.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18913b32a56c3cdd6c02134ed382a5f59acbc0d3", @"/Areas/Admin/Views/User/MemberDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_MemberDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Members", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
  
    ViewData["Title"] = "MemberDetails";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(150, 812, true);
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
                                    <h4>Manager Images</h4>
                                </div>
                            </div>
                        </div>
                        <div class=""avatar avatar-xl row justify-content-around"">
                            ");
            EndContext();
            BeginContext(962, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "18913b32a56c3cdd6c02134ed382a5f59acbc0d36560", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 972, "~/image/Users/", 972, 14, true);
#line 22 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
AddHtmlAttributeValue("", 986, Model.Image, 986, 12, false);

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
            BeginContext(1030, 1071, true);
            WriteLiteral(@"
                        </div>
                        <div class=""widget-header"">
                            <div class=""row"">
                                <div class=""col-xl-12 col-md-12 col-sm-12 col-12 mt-5 mb-3 text-center"">
                                    <h4>Manager Details</h4>
                                </div>
                            </div>
                        </div>
                        <div class=""table-responsive"">
                            <table class=""table mb-2"">
                                <thead>
                                    <tr>
                                        <th class=""text-center"">Name</th>
                                        <th class=""text-center"">Surname</th>
                                        <th class=""text-center"">Profession</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                 ");
            WriteLiteral("                       <td class=\"text-center\">");
            EndContext();
            BeginContext(2102, 15, false);
#line 42 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                                                           Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2117, 71, true);
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\">");
            EndContext();
            BeginContext(2189, 14, false);
#line 43 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                                                           Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2203, 71, true);
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\">");
            EndContext();
            BeginContext(2275, 13, false);
#line 44 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                                                           Write(Model.Section);

#line default
#line hidden
            EndContext();
            BeginContext(2288, 744, true);
            WriteLiteral(@"</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <div class=""table-responsive"">
                            <table class=""table mb-2"">
                                <thead>
                                    <tr>
                                        <th class=""text-center"">UserName</th>
                                        <th class=""text-center"">Email</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td class=""text-center"">");
            EndContext();
            BeginContext(3033, 14, false);
#line 59 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                                                           Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(3047, 71, true);
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\">");
            EndContext();
            BeginContext(3119, 11, false);
#line 60 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                                                           Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3130, 1111, true);
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
            BeginContext(4242, 14, false);
#line 82 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                                                           Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(4256, 71, true);
            WriteLiteral("</td>\r\n                                        <td class=\"text-center\">");
            EndContext();
            BeginContext(4328, 11, false);
#line 83 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                                                           Write(Model.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(4339, 661, true);
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
                                    <h4>Manager Bio</h4>
                                </div>
                            </div>
                        </div>
                        <p>");
            EndContext();
            BeginContext(5001, 17, false);
#line 97 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                      Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(5018, 460, true);
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
#line 107 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                         if (Model.FacebookLink != null)
                        {

#line default
#line hidden
            BeginContext(5563, 548, true);
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
            BeginWriteAttribute("href", " href=\"", 6111, "\"", 6137, 1);
#line 118 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
WriteAttributeValue("", 6118, Model.FacebookLink, 6118, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6138, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(6140, 18, false);
#line 118 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                                                                                             Write(Model.FacebookLink);

#line default
#line hidden
            EndContext();
            BeginContext(6158, 182, true);
            WriteLiteral("</a></td>\r\n                                        </tr>\r\n                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n");
            EndContext();
#line 123 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                        }

#line default
#line hidden
#line 124 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                         if (Model.InstagramLink != null)
                        {

#line default
#line hidden
            BeginContext(6453, 549, true);
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
            BeginWriteAttribute("href", " href=\"", 7002, "\"", 7029, 1);
#line 135 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
WriteAttributeValue("", 7009, Model.InstagramLink, 7009, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7030, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(7032, 19, false);
#line 135 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                                                                                              Write(Model.InstagramLink);

#line default
#line hidden
            EndContext();
            BeginContext(7051, 182, true);
            WriteLiteral("</a></td>\r\n                                        </tr>\r\n                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n");
            EndContext();
#line 140 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                        }

#line default
#line hidden
#line 141 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                         if (Model.TwitterLink != null)
                        {

#line default
#line hidden
            BeginContext(7344, 547, true);
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
            BeginWriteAttribute("href", " href=\"", 7891, "\"", 7916, 1);
#line 152 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
WriteAttributeValue("", 7898, Model.TwitterLink, 7898, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7917, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(7919, 17, false);
#line 152 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                                                                                            Write(Model.TwitterLink);

#line default
#line hidden
            EndContext();
            BeginContext(7936, 182, true);
            WriteLiteral("</a></td>\r\n                                        </tr>\r\n                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n");
            EndContext();
#line 157 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                        }

#line default
#line hidden
#line 158 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                         if (Model.LinkedinLink != null)
                        {

#line default
#line hidden
            BeginContext(8230, 548, true);
            WriteLiteral(@"                            <div class=""table-responsive"">
                                <table class=""table mb-2"">
                                    <thead>
                                        <tr>
                                            <th class=""text-center"">Linkedin</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td class=""text-center""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8778, "\"", 8804, 1);
#line 169 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
WriteAttributeValue("", 8785, Model.LinkedinLink, 8785, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8805, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(8807, 18, false);
#line 169 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                                                                                             Write(Model.LinkedinLink);

#line default
#line hidden
            EndContext();
            BeginContext(8825, 182, true);
            WriteLiteral("</a></td>\r\n                                        </tr>\r\n                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n");
            EndContext();
#line 174 "D:\My Lessons\HomeWork\P213\Final Project\Final Project AutoClub\AutoClub\AutoClub\Areas\Admin\Views\User\MemberDetails.cshtml"
                        }

#line default
#line hidden
            BeginContext(9034, 84, true);
            WriteLiteral("                        <div class=\"col-12 px-0 pt-5\">\r\n                            ");
            EndContext();
            BeginContext(9118, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18913b32a56c3cdd6c02134ed382a5f59acbc0d325267", async() => {
                BeginContext(9225, 7, true);
                WriteLiteral("Go Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9236, 140, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
