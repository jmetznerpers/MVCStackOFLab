#pragma checksum "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a39467d29f7c0cd1159d6bca2bd27317f47f51f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QandA_ViewQuestion), @"mvc.1.0.view", @"/Views/QandA/ViewQuestion.cshtml")]
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
#line 1 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\_ViewImports.cshtml"
using FoCStackOverflowLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\_ViewImports.cshtml"
using FoCStackOverflowLab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a39467d29f7c0cd1159d6bca2bd27317f47f51f", @"/Views/QandA/ViewQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3ddfdedb6cd5d09f7dd70079f284f06bd630041", @"/Views/_ViewImports.cshtml")]
    public class Views_QandA_ViewQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Questions>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewAnswer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewAnswer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewQuestion.cshtml"
  
    ViewData["Title"] = "ViewQuestion";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>View Question</h1>\r\n\r\n<div>\r\n    <h2>Submitted by: ");
#nullable restore
#line 9 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewQuestion.cshtml"
                 Write(Model.username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Title: ");
#nullable restore
#line 9 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewQuestion.cshtml"
                                        Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /></h2>\r\n    <hr />\r\n    Details: ");
#nullable restore
#line 11 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewQuestion.cshtml"
        Write(Model.detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    <hr />\r\n    Posted: ");
#nullable restore
#line 13 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewQuestion.cshtml"
       Write(Model.posted);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    <hr />\r\n    ");
#nullable restore
#line 15 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewQuestion.cshtml"
Write(Model.category);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    ");
#nullable restore
#line 16 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewQuestion.cshtml"
Write(Model.tags);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    ");
#nullable restore
#line 17 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewQuestion.cshtml"
Write(Model.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 18 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewQuestion.cshtml"
     if (DAL.CurrentUser == @Model.username)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 414, "\"", 459, 2);
            WriteAttributeValue("", 421, "/QandA/EditQuestion?questid=", 421, 28, true);
#nullable restore
#line 20 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewQuestion.cshtml"
WriteAttributeValue("", 449, Model.qid, 449, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Edit Question</a>\r\n");
#nullable restore
#line 21 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewQuestion.cshtml"
    }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>Login to edit!</span>\r\n");
#nullable restore
#line 25 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewQuestion.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a39467d29f7c0cd1159d6bca2bd27317f47f51f6977", async() => {
                WriteLiteral("View Answer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-questid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewQuestion.cshtml"
                                          WriteLiteral(Model.qid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["questid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-questid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["questid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td> \r\n<br/>\r\n");
#nullable restore
#line 30 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewQuestion.cshtml"
     if (DAL.CurrentUser != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a39467d29f7c0cd1159d6bca2bd27317f47f51f9415", async() => {
                WriteLiteral("Submit an Answer!");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-questid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewQuestion.cshtml"
                                         WriteLiteral(Model.qid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["questid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-questid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["questid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
#nullable restore
#line 33 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewQuestion.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Questions> Html { get; private set; }
    }
}
#pragma warning restore 1591