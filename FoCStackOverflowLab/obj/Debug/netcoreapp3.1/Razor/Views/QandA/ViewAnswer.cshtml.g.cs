#pragma checksum "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewAnswer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d2a073ed47fc2ce90c9871eb1901236295deca2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QandA_ViewAnswer), @"mvc.1.0.view", @"/Views/QandA/ViewAnswer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d2a073ed47fc2ce90c9871eb1901236295deca2", @"/Views/QandA/ViewAnswer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3ddfdedb6cd5d09f7dd70079f284f06bd630041", @"/Views/_ViewImports.cshtml")]
    public class Views_QandA_ViewAnswer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionsAndAnswers>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewAnswer.cshtml"
  
    ViewData["Title"] = "ViewAnswer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>View Answer to ");
#nullable restore
#line 6 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewAnswer.cshtml"
              Write(Model.quest.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 7 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewAnswer.cshtml"
 foreach (Answer ans in Model.answe)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 11 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewAnswer.cshtml"
Write(ans.aid);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Submitted by: ");
#nullable restore
#line 11 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewAnswer.cshtml"
                      Write(ans.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    <hr />\r\n    Question\r\n    <br />\r\n    ");
#nullable restore
#line 15 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewAnswer.cshtml"
Write(Model.quest.detail);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n    <hr />\r\n    Answer\r\n    <br />\r\n    ");
#nullable restore
#line 19 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewAnswer.cshtml"
Write(ans.detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    <hr />\r\n    ");
#nullable restore
#line 21 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewAnswer.cshtml"
Write(ans.posted);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    <hr />\r\n    ");
#nullable restore
#line 23 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewAnswer.cshtml"
Write(ans.upvotes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
#nullable restore
#line 26 "C:\Repos\FoCStackOverflowLab\FoCStackOverflowLab\Views\QandA\ViewAnswer.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionsAndAnswers> Html { get; private set; }
    }
}
#pragma warning restore 1591
