#pragma checksum "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b1f2f36c41abde8d50eead0919bd775a589a77e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b1f2f36c41abde8d50eead0919bd775a589a77e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39e511401de74b751ebd2b2769ffe6d3c92a8f39", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Fish>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;height:auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Jesteś pewny?! Zmiany będą nieodwracalne!\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1 class=""bg-danger"" style=""text-align:center"">Ostatnio Złapane Ryby</h1>
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
#line 13 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
             if (User.IsInRole("admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th scope=\"col\">Działania</th>\r\n");
#nullable restore
#line 16 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 21 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n");
#nullable restore
#line 25 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                 switch (item.MemberId)
                {
                    case 15:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Krzychu</p>\r\n");
#nullable restore
#line 29 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case 14:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Łapa</p>\r\n");
#nullable restore
#line 32 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case 13:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Jopek</p>\r\n");
#nullable restore
#line 35 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case 12:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Małpa</p>\r\n");
#nullable restore
#line 38 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case 16:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Milan</p>\r\n");
#nullable restore
#line 41 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    default:
                        break;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 47 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                 switch (item.KindOfFish)
                {
                    case KindOfFish.empty:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Brak</p>\r\n");
#nullable restore
#line 51 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case KindOfFish.pike:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Szczupak</p>\r\n");
#nullable restore
#line 54 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case KindOfFish.perch:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Okoń</p>\r\n");
#nullable restore
#line 57 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case KindOfFish.catfish:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Sum</p>\r\n");
#nullable restore
#line 60 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case KindOfFish.zander:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Sandacz</p>\r\n");
#nullable restore
#line 63 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case KindOfFish.chub:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Kleń</p>\r\n");
#nullable restore
#line 66 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case KindOfFish.asp:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Boleń</p>\r\n");
#nullable restore
#line 69 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    case KindOfFish.trout:

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Pstrąg</p>\r\n");
#nullable restore
#line 72 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        break;
                    default:
                        break;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
           Write(item.Lenght);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 81 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
           Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5b1f2f36c41abde8d50eead0919bd775a589a77e13203", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/images/");
#nullable restore
#line 83 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                        WriteLiteral(item.FishImage);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 83 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
#nullable restore
#line 84 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
             if (User.IsInRole("admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("   <td>\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b1f2f36c41abde8d50eead0919bd775a589a77e15995", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b1f2f36c41abde8d50eead0919bd775a589a77e16278", async() => {
                    WriteLiteral("Usuń rybkę");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
                                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
#line 91 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 93 "C:\Users\krzys\Desktop\FishingRankingWebApp\FRSolution\FishingRankingWebApp\Views\Home\Index.cshtml"
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
