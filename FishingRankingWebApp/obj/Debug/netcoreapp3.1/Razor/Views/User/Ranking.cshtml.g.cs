#pragma checksum "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c063b23e35a991bc0ddbd28fa33eecdabc252d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Ranking), @"mvc.1.0.view", @"/Views/User/Ranking.cshtml")]
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
#line 1 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\_ViewImports.cshtml"
using FishingRankingWebApp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\_ViewImports.cshtml"
using FishingRankingWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c063b23e35a991bc0ddbd28fa33eecdabc252d7", @"/Views/User/Ranking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39e511401de74b751ebd2b2769ffe6d3c92a8f39", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Ranking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Member>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/rb.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;height:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/bw.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/ml.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/nw.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/kj.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<h1 class=""bg-danger"" style=""text-align:center"">Ranking</h1>
<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Imię</th>
            <th scope=""col"">Nazwisko</th>
            <th scope=""col"">Punkty</th>
            <th scope=""col"">Ostatnia Ryba</th>
            <th scope=""col"">Ostatnia Aktywność</th>
            <th scope=""col"">Avatar</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 16 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
          
            int i = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
         foreach (var item in Model.OrderByDescending(s=>s.AmmountOfPoints))
        {
            {
                i++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 25 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
               Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
               Write(item.AmmountOfPoints);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 30 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
                     switch (item.LastCaughtFish)
                    {
                        case KindOfFish.pike:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Szczupak</p>\r\n");
#nullable restore
#line 34 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
                            break;
                        case KindOfFish.catfish:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Sum</p>\r\n");
#nullable restore
#line 37 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
                            break;
                        case KindOfFish.perch:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Okoń</p>\r\n");
#nullable restore
#line 40 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
                            break;
                        case KindOfFish.trout:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Pstrąg</p>\r\n");
#nullable restore
#line 43 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
                            break;
                        case KindOfFish.chub:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Kleń</p>\r\n");
#nullable restore
#line 46 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
                            break;
                        case KindOfFish.zander:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Sandacz</p>\r\n");
#nullable restore
#line 49 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
                            break;
                        case KindOfFish.asp:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Boleń</p>\r\n");
#nullable restore
#line 52 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
                            break;
                        default:
                            break;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>");
#nullable restore
#line 57 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
               Write(String.Format("{0:dd/MM/yyy}", item.RecentActivity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>\r\n");
#nullable restore
#line 60 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
                     if (item.FirstName == "Radek")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c063b23e35a991bc0ddbd28fa33eecdabc252d711284", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
                     if (item.FirstName == "Bartek")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c063b23e35a991bc0ddbd28fa33eecdabc252d712919", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 67 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
                     if (item.FirstName == "Marcin")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c063b23e35a991bc0ddbd28fa33eecdabc252d714554", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 71 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
                     if (item.FirstName == "Norbert")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c063b23e35a991bc0ddbd28fa33eecdabc252d716190", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 75 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
                     if (item.FirstName == "Krzysztof")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1c063b23e35a991bc0ddbd28fa33eecdabc252d717828", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 79 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 82 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\User\Ranking.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Member>> Html { get; private set; }
    }
}
#pragma warning restore 1591
