#pragma checksum "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a610fcae18aa0a708834acd750b436bf8ccf1114"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebAppSynthesis.Pages.Pages_TournamentPage), @"mvc.1.0.razor-page", @"/Pages/TournamentPage.cshtml")]
namespace WebAppSynthesis.Pages
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
#line 1 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\_ViewImports.cshtml"
using WebAppSynthesis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
using Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a610fcae18aa0a708834acd750b436bf8ccf1114", @"/Pages/TournamentPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2d08a20d3b4f10657ca7a4f6f09d9ce4682bdbb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_TournamentPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "SignUpForTournament", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Sign in for tournament"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100px; height: 60px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "DERegisterForTournament", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Deregister from tournament"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px; height:60px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"card-header\">\r\n\r\n        <div class=\"d-flex\">\r\n            <div class=\"p-1\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a610fcae18aa0a708834acd750b436bf8ccf11146876", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                     if (ViewData["CurrentEmail"] != null && Model.ObjT.RegisterDeadline >= DateTime.Now && Model.PlayersSignedIn < Model.ObjT.MaxPlayers && !Model.IsPlayerRegisterd)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"hidden\" name=\"idTournament\"");
                BeginWriteAttribute("value", " value=\"", 512, "\"", 564, 1);
#nullable restore
#line 14 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
WriteAttributeValue("", 520, Html.DisplayTextFor(model => Model.ObjT.ID), 520, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a610fcae18aa0a708834acd750b436bf8ccf11148205", async() => {
                    WriteLiteral("\r\n                            Sign in\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                     if (ViewData["CurrentEmail"] != null && Model.ObjT.RegisterDeadline >= DateTime.Now && Model.IsPlayerRegisterd)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"hidden\" name=\"idTournament\"");
                BeginWriteAttribute("value", " value=\"", 1047, "\"", 1099, 1);
#nullable restore
#line 22 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
WriteAttributeValue("", 1055, Html.DisplayTextFor(model => Model.ObjT.ID), 1055, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a610fcae18aa0a708834acd750b436bf8ccf111411102", async() => {
                    WriteLiteral("\r\n                            Deregister\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"p-4\">\r\n                <div class=\"d-flex flex-column\">\r\n                    <div>\r\n                        <b>Name:</b>\r\n                        ");
#nullable restore
#line 33 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                   Write(Model.ObjT.TournamentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                        <b>Location:</b>\r\n                        ");
#nullable restore
#line 37 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                   Write(Model.ObjT.TournamentLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                        <b>Start:</b>\r\n                        ");
#nullable restore
#line 41 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                   Write(Model.ObjT.TournamentStart.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                        <b>End:</b>\r\n                        ");
#nullable restore
#line 45 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                   Write(Model.ObjT.TournamentEnd.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                        <b>Register Deadline:</b>\r\n                        ");
#nullable restore
#line 49 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                   Write(Model.ObjT.RegisterDeadline.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                        <b>Information:</b>\r\n                        ");
#nullable restore
#line 53 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                   Write(Model.ObjT.TournamentInfo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                        <b>Total number of player registered:</b>\r\n                        ");
#nullable restore
#line 57 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                   Write(Model.PlayersSignedIn);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 57 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                                            Write(Model.ObjT.MaxPlayers);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"card-header  alert-success\">\r\n        <div>\r\n            <b>Gold Winner:</b>\r\n");
#nullable restore
#line 67 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
             if (@Model.ObjT.NameGoldWinner != null && @Model.ObjT.Gold != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
           Write(Model.ObjT.NameGoldWinner);

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                                          
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span> No gold winner has been decided yet!</span>\r\n");
#nullable restore
#line 74 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div>\r\n            <b>Silver Winner:</b>\r\n");
#nullable restore
#line 78 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
             if (@Model.ObjT.NameSilverWinner != null && @Model.ObjT.Silver != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
           Write(Model.ObjT.NameSilverWinner);

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                                            
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span> No silver winner has been decided yet!</span>\r\n");
#nullable restore
#line 85 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div>\r\n            <b>Bronze Winner:</b>\r\n");
#nullable restore
#line 89 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
             if (@Model.ObjT.NameBronzeWinner != null && @Model.ObjT.Bronze != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
           Write(Model.ObjT.NameBronzeWinner);

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                                            
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>No bronze winner has been decided yet!</span>\r\n");
#nullable restore
#line 96 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"card-body\">\r\n");
#nullable restore
#line 102 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
         if (Model.Leaderboard != null && Model.Leaderboard.Count != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h2>Leaderboard</h2>
            <table>
                <tr>
                    <th class=""card-columns""><span class=""card-title"">Name         </span>   </th>
                    <th class=""card-columns""><span class=""card-title"">Victories    </span>   </th>
                </tr>
");
#nullable restore
#line 110 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                 foreach (Object[] result in Model.Leaderboard)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"align-items-md-center \">\r\n\r\n                        <td class=\"card-columns\">");
#nullable restore
#line 114 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                                            Write(result[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"card-columns\">");
#nullable restore
#line 115 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                                            Write(result[2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 118 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n");
#nullable restore
#line 120 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"alert-info\"> Leaderboard for this tournament has not been created yet.</span>\r\n");
#nullable restore
#line 124 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n    <div class=\"card-body\">\r\n");
#nullable restore
#line 129 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
         if (Model.MatchSchedule != null && Model.MatchSchedule.Count != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h2>Match schedule</h2>
            <table>
                <tr>
                    <th class=""card-columns""><span class=""card-title""> Player 1     </span>   </th>
                    <th class=""card-columns""><span class=""card-title""> Player 2     </span>   </th>
                    <th class=""card-columns""><span class=""card-title""> Match Start  </span>   </th>
                    <th class=""card-columns""><span class=""card-title""> Winner       </span>   </th>
                </tr>
");
#nullable restore
#line 139 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                 foreach (Match m in Model.MatchSchedule)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"card-columns\">");
#nullable restore
#line 142 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                                            Write(m.Player1Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"card-columns\">");
#nullable restore
#line 143 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                                            Write(m.Player2Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"card-columns\">");
#nullable restore
#line 144 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                                            Write(m.MatchStart.Date.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"card-columns\">");
#nullable restore
#line 145 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                                            Write(m.WinnerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 147 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n");
#nullable restore
#line 149 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"alert-info\"> Schedule for this tournament has not been created yet.</span>\r\n");
#nullable restore
#line 153 "C:\Users\Misho\Desktop\Semester 2\Syntesis Assignment\synthesis-assignment-mihail-vasilev-s2-cb01\SynthesisAssignment\WebAppSynthesis\Pages\TournamentPage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppSynthesis.Pages.TournamentPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebAppSynthesis.Pages.TournamentPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebAppSynthesis.Pages.TournamentPageModel>)PageContext?.ViewData;
        public WebAppSynthesis.Pages.TournamentPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591