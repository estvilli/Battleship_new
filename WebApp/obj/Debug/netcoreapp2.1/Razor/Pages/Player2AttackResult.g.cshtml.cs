#pragma checksum "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e67fc65fd90d2bf6d34ab04d8044e3c7709082e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp.Pages.Pages_Player2AttackResult), @"mvc.1.0.razor-page", @"/Pages/Player2AttackResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Player2AttackResult.cshtml", typeof(WebApp.Pages.Pages_Player2AttackResult), null)]
namespace WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#line 2 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
using Domain;

#line default
#line hidden
#line 3 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
using GameUI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e67fc65fd90d2bf6d34ab04d8044e3c7709082e", @"/Pages/Player2AttackResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56255396305d1d1888ad93afc9c47568e44a4220", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Player2AttackResult : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
  
    ViewData["Title"] = "Player 2 attack result";

#line default
#line hidden
            BeginContext(121, 2581, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15ce5041e5734299bf8aa047f6dfe8e1", async() => {
                BeginContext(127, 2, true);
                WriteLiteral("\n\n");
                EndContext();
#line 10 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
 if (ObjectHolderForWebApp.GameBoard.hitOrMiss == BoardSquareState.Hit)
{

#line default
#line hidden
                BeginContext(203, 18, true);
                WriteLiteral("    <h3>Hit!</h3>\n");
                EndContext();
#line 13 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
}
else
{

#line default
#line hidden
                BeginContext(230, 19, true);
                WriteLiteral("    <h3>Miss!</h3>\n");
                EndContext();
#line 17 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
}

#line default
#line hidden
                BeginContext(251, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 19 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
 if (ObjectHolderForWebApp.GameBoard.shipSquareCount == 0)
{
    ObjectHolderForWebApp.ContinuePlaying = false;

#line default
#line hidden
                BeginContext(364, 44, true);
                WriteLiteral("    <h3>Congratulations! Player 2 won!</h3>\n");
                EndContext();
#line 23 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"

}

#line default
#line hidden
                BeginContext(411, 137, true);
                WriteLiteral("\n<h3>Player 2 enemy ships table</h3>\n<table style=\"border: 1px solid black\">\n    <tr>\n        <td style=\"border: 1px solid black\"> </td>\n");
                EndContext();
#line 30 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
         for (int a = 0; a < GameUI.ObjectHolderForWebApp.GameBoard.Player2Board2[0].Count; a++)
        {

#line default
#line hidden
                BeginContext(655, 48, true);
                WriteLiteral("            <td style=\"border: 1px solid black\">");
                EndContext();
                BeginContext(704, 50, false);
#line 32 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
                                           Write(GameUI.ObjectHolderForWebApp.GameBoard.Alphabet[a]);

#line default
#line hidden
                EndContext();
                BeginContext(754, 6, true);
                WriteLiteral("</td>\n");
                EndContext();
#line 33 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
        }

#line default
#line hidden
                BeginContext(770, 10, true);
                WriteLiteral("    </tr>\n");
                EndContext();
#line 35 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
     for (int i = 0; i < GameUI.ObjectHolderForWebApp.GameBoard.Player2Board2.Count; i++)
    {

#line default
#line hidden
                BeginContext(876, 61, true);
                WriteLiteral("        <tr>\n            <td style=\"border: 1px solid black\">");
                EndContext();
                BeginContext(939, 5, false);
#line 38 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
                                            Write(i + 1);

#line default
#line hidden
                EndContext();
                BeginContext(945, 7, true);
                WriteLiteral("</td>\n\n");
                EndContext();
#line 40 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
             for (int j = 0; j < GameUI.ObjectHolderForWebApp.GameBoard.Player2Board2[i].Count; j++)
            {
                switch (GameUI.ObjectHolderForWebApp.GameBoard.Player2Board2[i][j])
                {
                    case BoardSquareState.Empty:

#line default
#line hidden
                BeginContext(1218, 94, true);
                WriteLiteral("                        <td style=\"border: 1px solid black; width: 50px; height: 50px\"> </td>\n");
                EndContext();
#line 46 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
                        break;
                    case BoardSquareState.Unknown:

#line default
#line hidden
                BeginContext(1394, 94, true);
                WriteLiteral("                        <td style=\"border: 1px solid black; width: 50px; height: 50px\">-</td>\n");
                EndContext();
#line 49 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
                        break;
                    case BoardSquareState.Ship:

#line default
#line hidden
                BeginContext(1567, 94, true);
                WriteLiteral("                        <td style=\"border: 1px solid black; width: 50px; height: 50px\">+</td>\n");
                EndContext();
#line 52 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
                        break;
                    case BoardSquareState.Hit:

#line default
#line hidden
                BeginContext(1739, 94, true);
                WriteLiteral("                        <td style=\"border: 1px solid black; width: 50px; height: 50px\">X</td>\n");
                EndContext();
#line 55 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
                        break;
                    case BoardSquareState.Miss:

#line default
#line hidden
                BeginContext(1912, 94, true);
                WriteLiteral("                        <td style=\"border: 1px solid black; width: 50px; height: 50px\">0</td>\n");
                EndContext();
#line 58 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

#line default
#line hidden
                BeginContext(2164, 14, true);
                WriteLiteral("        </tr>\n");
                EndContext();
#line 65 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
    }

#line default
#line hidden
                BeginContext(2184, 13, true);
                WriteLiteral("</table>\n\n\n\n\n");
                EndContext();
#line 71 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
 if (ObjectHolderForWebApp.GameBoard.shipSquareCount == 0)
{

#line default
#line hidden
                BeginContext(2258, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(2262, 226, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1d2e16bdcef455b8c70f8dd9a1561e1", async() => {
                    BeginContext(2282, 199, true);
                    WriteLiteral("\n        <fieldset>\n            <div>\n                <label>&nbsp;</label>\n                <input type=\"submit\" value=\"Start new game\" class=\"start_new\"/>\n            </div>\n        </fieldset>\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2488, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 81 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"

}

else {

#line default
#line hidden
                BeginContext(2500, 191, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fae764959e724780937efda59b07fb88", async() => {
                    BeginContext(2520, 164, true);
                    WriteLiteral("\n    <fieldset>\n        <div>\n            <label>&nbsp;</label>\n            <input type=\"submit\" value=\"Continue\" class=\"continue\"/>\n        </div>\n    </fieldset>\n");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2691, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 93 "/Users/williamstraus/Documents/Ulikool/C# programmeerimine/Projekt/Battleship/WebApp/Pages/Player2AttackResult.cshtml"
}

#line default
#line hidden
                BeginContext(2694, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Player2AttackResultModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Player2AttackResultModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Player2AttackResultModel>)PageContext?.ViewData;
        public Player2AttackResultModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591