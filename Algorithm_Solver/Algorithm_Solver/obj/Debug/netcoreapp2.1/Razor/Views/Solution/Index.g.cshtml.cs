#pragma checksum "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fb74349f423911bad74bfaad03c9def78d3f25b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Solution_Index), @"mvc.1.0.view", @"/Views/Solution/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Solution/Index.cshtml", typeof(AspNetCore.Views_Solution_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fb74349f423911bad74bfaad03c9def78d3f25b", @"/Views/Solution/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d379115d86d254da43d03a6585edf1a5ceeb0ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Solution_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Solution>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("taskId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Solution", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ValidateSolutionAsync", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-form col-sm-10 col-sm-offset-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(19, 78, true);
            WriteLiteral("\r\n<h2>Submition Form</h2>\r\n<div class=\"custom-form-container col-sm-12\">\r\n    ");
            EndContext();
            BeginContext(97, 2871, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12dae3bb554242db83a88e688fab7a83", async() => {
                BeginContext(163, 12, true);
                WriteLiteral("\r\n\r\n        ");
                EndContext();
                BeginContext(176, 28, false);
#line 8 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
                EndContext();
                BeginContext(204, 258, true);
                WriteLiteral(@"

        <div class=""form-group row"">
            <label for=""inputNickname"" class=""col-sm-2 col-form-label"">Nickname</label>
            <div class=""col-sm-8"" >
                <input name=""nickName"" type=""text"" id=""inputNickname"" class=""form-control""");
                EndContext();
                BeginWriteAttribute("value", " value=", 462, "", 484, 1);
#line 13 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
WriteAttributeValue("", 469, Model.nickName, 469, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(484, 19, true);
                WriteLiteral(">\r\n                ");
                EndContext();
                BeginContext(504, 86, false);
#line 14 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
           Write(Html.ValidationMessageFor(model => model.nickName, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(590, 316, true);
                WriteLiteral(@"
            </div>
        </div>

        <div class=""form-group row"">
            <label for=""selectTask"" class=""col-sm-2 col-form-label"">Task</label>
            <div class=""col-sm-8"">
                <select required name=""taskId"" class=""browser-default custom-select form-control"">
                    ");
                EndContext();
                BeginContext(906, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62b3a06e5faf430eaf90d0ca580857ac", async() => {
                    BeginContext(979, 6, true);
                    WriteLiteral("Select");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 22 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
AddHtmlAttributeValue("", 933, Model.selectedTask == null ? true : false, 933, 44, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(994, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 23 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
                     foreach (var task in Model.algorithmTasks)
                    {

#line default
#line hidden
                BeginContext(1084, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1108, 148, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f4cf5e80bfd4a32a9fcf9f9d9b7928d", async() => {
                    BeginContext(1238, 9, false);
#line 25 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
                                                                                                                                                    Write(task.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 25 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
AddHtmlAttributeValue("", 1126, Model.selectedTask != null && Model.selectedTask.Id == task.Id ? true : false, 1126, 80, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#line 25 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
                                                                                                                                    WriteLiteral(task.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1256, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 26 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1281, 347, true);
                WriteLiteral(@"                </select>
            </div>
        </div>

        <div class=""form-group row"">
            <label for=""inputCode"" class=""col-sm-2 col-form-label"">Solution</label>
            <div class=""col-sm-8"">
                <textarea name=""code"" class=""form-control rounded-0"" id=""inputCode"" rows=""5"" placeholder=""Type code in C#"">");
                EndContext();
                BeginContext(1629, 10, false);
#line 34 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
                                                                                                                      Write(Model.code);

#line default
#line hidden
                EndContext();
                BeginContext(1639, 33, true);
                WriteLiteral("</textarea>\r\n                <!--");
                EndContext();
                BeginContext(1673, 123, false);
#line 35 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
               Write(Html.TextArea("code", new { @class="form-control rounded-0", @id="inputCode", @rows="3", @placeholder= "Type code in C#" }));

#line default
#line hidden
                EndContext();
                BeginContext(1796, 51, true);
                WriteLiteral("-->\r\n            </div>\r\n        </div>\r\n\r\n        ");
                EndContext();
                BeginContext(1847, 153, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5dd589e08be4563898d1cd478cc1e35", async() => {
                    BeginContext(1961, 30, true);
                    WriteLiteral("\r\n            Submit\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2000, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 42 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
         if (Model.status != Solution.Status.Initial && Model.selectedTask != null)
        {
            

#line default
#line hidden
#line 44 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
             if (Model.status == Solution.Status.Success)
            {

#line default
#line hidden
                BeginContext(2172, 148, true);
                WriteLiteral("                <div class=\"panel panel-success\">\r\n                    <div class=\"panel-heading\">\r\n                        <h3 class=\"panel-title\">");
                EndContext();
                BeginContext(2321, 12, false);
#line 48 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
                                           Write(Model.status);

#line default
#line hidden
                EndContext();
                BeginContext(2333, 86, true);
                WriteLiteral("</h3>\r\n                    </div>\r\n                    <div class=\"panel-body\">Input: ");
                EndContext();
                BeginContext(2420, 24, false);
#line 50 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
                                              Write(Model.selectedTask.Input);

#line default
#line hidden
                EndContext();
                BeginContext(2444, 9, true);
                WriteLiteral(" Output: ");
                EndContext();
                BeginContext(2454, 25, false);
#line 50 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
                                                                                Write(Model.selectedTask.Output);

#line default
#line hidden
                EndContext();
                BeginContext(2479, 32, true);
                WriteLiteral("</div>\r\n                </div>\r\n");
                EndContext();
#line 52 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"

            }
            else if (Model.status == Solution.Status.Error)
            {

#line default
#line hidden
                BeginContext(2604, 147, true);
                WriteLiteral("                <div class=\"panel panel-danger\">\r\n                    <div class=\"panel-heading\">\r\n                        <h3 class=\"panel-title\">");
                EndContext();
                BeginContext(2752, 12, false);
#line 58 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
                                           Write(Model.status);

#line default
#line hidden
                EndContext();
                BeginContext(2764, 86, true);
                WriteLiteral("</h3>\r\n                    </div>\r\n                    <div class=\"panel-body\">Input: ");
                EndContext();
                BeginContext(2851, 24, false);
#line 60 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
                                              Write(Model.selectedTask.Input);

#line default
#line hidden
                EndContext();
                BeginContext(2875, 9, true);
                WriteLiteral(" Output: ");
                EndContext();
                BeginContext(2885, 12, false);
#line 60 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
                                                                                Write(Model.output);

#line default
#line hidden
                EndContext();
                BeginContext(2897, 32, true);
                WriteLiteral("</div>\r\n                </div>\r\n");
                EndContext();
#line 62 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
            }

#line default
#line hidden
#line 62 "E:\projects\Algorithm_Solver\Algorithm_Solver\Views\Solution\Index.cshtml"
             
        }

#line default
#line hidden
                BeginContext(2955, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2968, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Solution> Html { get; private set; }
    }
}
#pragma warning restore 1591