#pragma checksum "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Score\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b9eb66f43ec5c67d1f5f7790099245d7685fc41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Score_Index), @"mvc.1.0.view", @"/Views/Score/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Score/Index.cshtml", typeof(AspNetCore.Views_Score_Index))]
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
#line 1 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\_ViewImports.cshtml"
using Algorithm_Solver;

#line default
#line hidden
#line 2 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\_ViewImports.cshtml"
using Algorithm_Solver.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b9eb66f43ec5c67d1f5f7790099245d7685fc41", @"/Views/Score/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d379115d86d254da43d03a6585edf1a5ceeb0ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Score_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Score>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(22, 321, true);
            WriteLiteral(@"
<h2>Score Board</h2>
<table class=""table table-bordered table-hover"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Nickname</th>
            <th scope=""col"">Wins</th>
            <th scope=""col"">Losses</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 15 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Score\Index.cshtml"
         if (Model.Count > 0)
        {
            int place = 0;
            foreach (Score player in Model)
            {
                place++;

#line default
#line hidden
            BeginContext(499, 58, true);
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
            EndContext();
            BeginContext(558, 5, false);
#line 22 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Score\Index.cshtml"
                               Write(place);

#line default
#line hidden
            EndContext();
            BeginContext(563, 31, true);
            WriteLiteral("</th>\r\n                    <td>");
            EndContext();
            BeginContext(595, 15, false);
#line 23 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Score\Index.cshtml"
                   Write(player.NickName);

#line default
#line hidden
            EndContext();
            BeginContext(610, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(642, 11, false);
#line 24 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Score\Index.cshtml"
                   Write(player.Wins);

#line default
#line hidden
            EndContext();
            BeginContext(653, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(685, 13, false);
#line 25 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Score\Index.cshtml"
                   Write(player.Losses);

#line default
#line hidden
            EndContext();
            BeginContext(698, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 27 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Score\Index.cshtml"
            }
        }
        else {

#line default
#line hidden
            BeginContext(768, 39, true);
            WriteLiteral(" <td colspan=\"4\">No records found</td> ");
            EndContext();
#line 29 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Score\Index.cshtml"
                                                     }

#line default
#line hidden
            BeginContext(810, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Score>> Html { get; private set; }
    }
}
#pragma warning restore 1591
