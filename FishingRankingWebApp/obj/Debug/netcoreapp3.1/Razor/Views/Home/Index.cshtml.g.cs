#pragma checksum "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2c974ba4f541af0e15b9935050e543960acda98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2c974ba4f541af0e15b9935050e543960acda98", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de432be3c5febdb2f627cc59fbfd84b34209009f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Fish>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;height:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1 class=""bg-danger"" style=""text-align:center"">Ostatnio Złapane Ryby</h1>
<table class=""table"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Imię</th>
            <th scope=""col"">Rodzaj Ryby</th>
            <th scope=""col"">Długość</th>
            <th scope=""col"">Lokalizacja</th>
            <th scope=""col"">Zdjęcie ryby</th>
");
#nullable restore
#line 12 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
             if (User.IsInRole("admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th scope=\"col\">Działania</th>\r\n");
#nullable restore
#line 15 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n");
#nullable restore
#line 24 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                 switch (item.MemberId)
                {
                    case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Krzysztof</p>\r\n");
#nullable restore
#line 28 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Ryba od T.K</p>\r\n");
#nullable restore
#line 31 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Ryba od T.J</p>\r\n");
#nullable restore
#line 34 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case 4:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Ryba od R.B</p>\r\n");
#nullable restore
#line 37 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    default:
                        break;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 43 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                 switch (item.KindOfFish)
                {
                    case KindOfFish.empty:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Brak</p>\r\n");
#nullable restore
#line 47 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case KindOfFish.pike:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Szczupak</p>\r\n");
#nullable restore
#line 50 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case KindOfFish.perch:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Okoń</p>\r\n");
#nullable restore
#line 53 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case KindOfFish.catfish:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Sum</p>\r\n");
#nullable restore
#line 56 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case KindOfFish.zander:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Sandacz</p>\r\n");
#nullable restore
#line 59 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case KindOfFish.chub:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Kleń</p>\r\n");
#nullable restore
#line 62 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case KindOfFish.asp:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Boleń</p>\r\n");
#nullable restore
#line 65 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case KindOfFish.trout:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Pstrąg</p>\r\n");
#nullable restore
#line 68 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    default:
                        break;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
           Write(item.Lenght);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
           Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2c974ba4f541af0e15b9935050e543960acda9812726", async() => {
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
            WriteLiteral("</td>\r\n");
#nullable restore
#line 80 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
             if (User.IsInRole("admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("   <td>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2c974ba4f541af0e15b9935050e543960acda9814149", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2c974ba4f541af0e15b9935050e543960acda9814432", async() => {
                    WriteLiteral("Usuń rybkę");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n                </td>\r\n");
#nullable restore
#line 87 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 89 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Fish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
