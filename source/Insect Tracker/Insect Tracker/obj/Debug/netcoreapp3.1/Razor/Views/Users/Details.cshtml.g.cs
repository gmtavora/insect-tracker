#pragma checksum "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "555d0c73f729a62d2d4790e3ad252e6294fe0d63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
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
#line 1 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\_ViewImports.cshtml"
using Insect_Tracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml"
using Insect_Tracker.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml"
using Insect_Tracker.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"555d0c73f729a62d2d4790e3ad252e6294fe0d63", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86081c09b0bf6e9256f281d2e786479f77bb4565", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("big-user-pic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/blank-profile-wanderer-creative.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml"
  
    ViewData["Title"] = Model.FirstName + " " + Model.LastName;
    Layout = "_LayoutDashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"mt-4\">");
#nullable restore
#line 9 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml"
            Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml"
                             Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<ol class=\"breadcrumb mb-4\">\r\n    <li class=\"breadcrumb-item\"><a href=\"index.html\">Home</a></li>\r\n    <li class=\"breadcrumb-item\"><a href=\"#\">Users</a></li>\r\n    <li class=\"breadcrumb-item active\">");
#nullable restore
#line 13 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml"
                                  Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ol>\r\n\r\n<div class=\"card mb-3\">\r\n    <div class=\"card-body\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-3\">\r\n");
#nullable restore
#line 20 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml"
                 if (Model.ProfilePicture != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "555d0c73f729a62d2d4790e3ad252e6294fe0d636153", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 700, "~/", 700, 2, true);
#nullable restore
#line 22 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml"
AddHtmlAttributeValue("", 702, Directories.ATTACHMENTS, 702, 24, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml"
AddHtmlAttributeValue("", 726, Model.UserId, 726, 13, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 739, "", 740, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "555d0c73f729a62d2d4790e3ad252e6294fe0d638424", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n            <div class=\"col-sm-9\">\r\n                <table class=\"table table-sm\">\r\n                    <tr>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Roles));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Roles));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.DateSigned));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(model => model.DateSigned));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<button type=\"button\" class=\"btn btn-primary\">Return</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
