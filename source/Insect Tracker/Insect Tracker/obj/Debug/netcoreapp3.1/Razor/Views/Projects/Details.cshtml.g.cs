#pragma checksum "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0a6a6f6c8bda60897dc8e999219acfa63eb1143"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Details), @"mvc.1.0.view", @"/Views/Projects/Details.cshtml")]
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
#line 2 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\_ViewImports.cshtml"
using Insect_Tracker.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0a6a6f6c8bda60897dc8e999219acfa63eb1143", @"/Views/Projects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86081c09b0bf6e9256f281d2e786479f77bb4565", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Insect_Tracker.Models.Project>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Projects/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
  
    ViewData["Title"] = "Projects";
    Layout = "_LayoutDashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"mt-4\">Project</h1>\r\n<ol class=\"breadcrumb mb-4\">\r\n    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0a6a6f6c8bda60897dc8e999219acfa63eb11434657", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0a6a6f6c8bda60897dc8e999219acfa63eb11435769", async() => {
                WriteLiteral("Projects");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n    <li class=\"breadcrumb-item active\">");
#nullable restore
#line 14 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
                                  Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ol>\r\n\r\n<div class=\"card mb-3\">\r\n    <div class=\"card-body\">\r\n        <h5>");
#nullable restore
#line 19 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 20 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
         if (Model.Finished)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"badge rounded-pill bg-success mb-3\">Finished</span>\r\n");
#nullable restore
#line 23 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"badge rounded-pill bg-primary mb-3\">In Progress</span>\r\n");
#nullable restore
#line 27 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <p>");
#nullable restore
#line 29 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <table class=\"table mb-3\">\r\n            <tr>\r\n                <td>Created by</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
               Write(Model.Creator.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 33 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
                                         Write(Model.Creator.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Started</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
               Write(Model.DateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Last modified</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
               Write(Model.LastModified);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
             if (Model.Finished)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>Finished</td>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
                   Write(Model.DateFinished);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n\r\n");
#nullable restore
#line 52 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
         if (!Model.Finished)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"button\" class=\"btn btn-primary\">Finish</button>\r\n            <button type=\"button\" class=\"btn btn-primary\">Edit</button>\r\n");
#nullable restore
#line 56 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"button\" class=\"btn btn-primary\">Reopen</button>\r\n");
#nullable restore
#line 60 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <button type=""button"" class=""btn btn-primary"">Remove</button>
    </div>
</div>

<div class=""card mb-3"">
    <div class=""card-header"">
        Users
    </div>
    <div class=""card-body"">
        <table id=""users"" class=""table table-sm table-hover"">
            <thead>
                <tr>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Roles</th>
                </tr>
            </thead>

            <tbody>
");
#nullable restore
#line 79 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
                 foreach (UserProject user in Model.Users)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 82 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
                       Write(user.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 82 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
                                            Write(user.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 83 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
                       Write(string.Join(", ", UserManager.GetRolesAsync(user.User).Result.ToList()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 85 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>

<div class=""card"">
    <div class=""card-header"">
        Tickets
    </div>
    <div class=""card-body"">
        <table id=""tickets"" class=""table table-sm table-hover"">
            <thead>
                <tr>
                    <th scope=""col"">Title</th>
                    <th scope=""col"">Author</th>
                    <th scope=""col"">Last Modified</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 105 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
                 foreach (Ticket ticket in Model.Tickets)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 108 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
                       Write(ticket.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 109 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
                       Write(ticket.Author.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 109 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
                                                Write(ticket.Author.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 110 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
                       Write(ticket.LastModified);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 112 "C:\Users\Gabriel\Documents\Projetos\InsectTracker\insect-tracker\source\Insect Tracker\Insect Tracker\Views\Projects\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#users\').DataTable();\r\n            $(\'#tickets\').DataTable();\r\n        });\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Insect_Tracker.Models.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
