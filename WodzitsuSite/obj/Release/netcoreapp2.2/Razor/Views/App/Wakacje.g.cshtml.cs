#pragma checksum "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a6c59409047f6d296739d58d8283ea807c2e886"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_Wakacje), @"mvc.1.0.view", @"/Views/App/Wakacje.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/App/Wakacje.cshtml", typeof(AspNetCore.Views_App_Wakacje))]
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
#line 1 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\_ViewImports.cshtml"
using WodzitsuSite.Controllers;

#line default
#line hidden
#line 2 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\_ViewImports.cshtml"
using WodzitsuSite.Data;

#line default
#line hidden
#line 3 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\_ViewImports.cshtml"
using WodzitsuSite.Data.Entities;

#line default
#line hidden
#line 4 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\_ViewImports.cshtml"
using WodzitsuSite.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a6c59409047f6d296739d58d8283ea807c2e886", @"/Views/App/Wakacje.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"665da5a64510d504d23cd14bda424716978ac717", @"/_ViewImports.cshtml")]
    public class Views_App_Wakacje : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ScoreViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/JavaScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid img-rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "App", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Score", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-2 mt-2 btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(118, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(181, 4, true);
                WriteLiteral("\t\t\r\n");
                EndContext();
                BeginContext(185, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a6c59409047f6d296739d58d8283ea807c2e8866412", async() => {
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
                EndContext();
                BeginContext(227, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(232, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
 foreach (var p in Model)
{

#line default
#line hidden
            BeginContext(264, 82, true);
            WriteLiteral("\t<div class=\"row border bg-light rounded p-1 mb-2\">\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t");
            EndContext();
            BeginContext(346, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a6c59409047f6d296739d58d8283ea807c2e8868124", async() => {
                BeginContext(415, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a6c59409047f6d296739d58d8283ea807c2e8868387", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 425, "~/img/", 425, 6, true);
#line 15 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
AddHtmlAttributeValue("", 431, p.tour.Zdjecie, 431, 15, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
                                                         WriteLiteral(p.tour.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(484, 46, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div class=\"col-md-7\">\r\n\t\t\t<div>");
            EndContext();
            BeginContext(531, 11, false);
#line 18 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
            Write(p.tour.Name);

#line default
#line hidden
            EndContext();
            BeginContext(542, 33, true);
            WriteLiteral("</div>\r\n\t\t\t<ul>\r\n\t\t\t\t<li>Termin: ");
            EndContext();
            BeginContext(576, 43, false);
#line 20 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
                       Write(p.tour.TerminOd.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(619, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(623, 43, false);
#line 20 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
                                                                      Write(p.tour.TerminDo.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(666, 15, true);
            WriteLiteral("</li>\r\n\t\t\t\t<li>");
            EndContext();
            BeginContext(682, 19, false);
#line 21 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
               Write(p.tour.SamolotFirma);

#line default
#line hidden
            EndContext();
            BeginContext(701, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(704, 33, false);
#line 21 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
                                     Write(p.tour.SamolotCena.ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(737, 20, true);
            WriteLiteral(" zł</li>\r\n\t\t\t\t<li><a");
            EndContext();
            BeginWriteAttribute("href", " href=", 757, "", 776, 1);
#line 22 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
WriteAttributeValue("", 763, p.tour.Hotel, 763, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(776, 28, true);
            WriteLiteral(" target=\"_blank\">Hotel: </a>");
            EndContext();
            BeginContext(805, 31, false);
#line 22 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
                                                                Write(p.tour.HotelCena.ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(836, 31, true);
            WriteLiteral(" zł</li>\r\n\t\t\t\t<li>Organizator: ");
            EndContext();
            BeginContext(868, 18, false);
#line 23 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
                            Write(p.tour.Organizator);

#line default
#line hidden
            EndContext();
            BeginContext(886, 48, true);
            WriteLiteral("</li>\r\n\t\t\t</ul>\r\n\t\t\t<div class=\"opis-wycieczki\">");
            EndContext();
            BeginContext(935, 11, false);
#line 25 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
                                   Write(p.tour.Opis);

#line default
#line hidden
            EndContext();
            BeginContext(946, 85, true);
            WriteLiteral("</div>\r\n\t\t\t\r\n\t\t</div>\r\n\t\t<div class=\"col-md-2\">\r\n\t\t\t<div class=\"price-summary\">Cena: ");
            EndContext();
            BeginContext(1033, 54, false);
#line 29 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
                                         Write((p.tour.HotelCena + p.tour.SamolotCena).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 56, true);
            WriteLiteral(" zł</div>\r\n\t\t\t<div class=\"justify-content-center\">\r\n\t\t\t\t");
            EndContext();
            BeginContext(1144, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a6c59409047f6d296739d58d8283ea807c2e88616191", async() => {
                BeginContext(1256, 6, true);
                WriteLiteral("Edytuj");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
                                                            WriteLiteral(p.tour.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1266, 131, true);
            WriteLiteral("\r\n\t\t\t\t<button type=\"button\" class=\"identifyingClass btn btn-warning btn-block\" data-toggle=\"modal\" data-target=\"#myModal\" data-id=\"");
            EndContext();
            BeginContext(1398, 9, false);
#line 32 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
                                                                                                                                        Write(p.tour.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1407, 13, true);
            WriteLiteral("\" data-name=\"");
            EndContext();
            BeginContext(1421, 11, false);
#line 32 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
                                                                                                                                                               Write(p.tour.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1432, 95, true);
            WriteLiteral("\">Usuń</button>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"container align-content-md-end\">\r\n\t\t\t\t<div>Średnia: ");
            EndContext();
            BeginContext(1528, 25, false);
#line 35 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
                         Write(p.ScoreAvg.ToString("F0"));

#line default
#line hidden
            EndContext();
            BeginContext(1553, 23, true);
            WriteLiteral("</div>\r\n\t\t\t\t<div>Suma: ");
            EndContext();
            BeginContext(1577, 27, false);
#line 36 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
                      Write(p.ScoreTotal.ToString("F0"));

#line default
#line hidden
            EndContext();
            BeginContext(1604, 38, true);
            WriteLiteral("</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");
            EndContext();
#line 40 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
}

#line default
#line hidden
            BeginContext(1645, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a6c59409047f6d296739d58d8283ea807c2e88620867", async() => {
                BeginContext(1710, 15, true);
                WriteLiteral("Dodaj Wycieczkę");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1729, 219, true);
            WriteLiteral("\r\n\r\n<div id=\"myModal\" class=\"modal fade\" role=\"dialog\">\r\n\t<div class=\"modal-dialog\">\r\n\t\t<!-- Modal content-->\r\n\t\t<div class=\"modal-content\">\r\n\t\t\t<div class=\"modal-header\">\r\n\t\t\t\t<h4 class=\"modal-title\"></h4>\r\n\t\t\t</div>\r\n");
            EndContext();
#line 50 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
             if (User.Identity.Name.Equals("FilipMaster"))
			{

#line default
#line hidden
            BeginContext(2005, 265, true);
            WriteLiteral(@"				<div class=""modal-body"">
					<p>Jestes pewien ze chcesz usunąć tą wycieczkę?</p>
				</div>
				<div class=""modal-footer"">

					<a class=""btn btn-primary"" data-dismiss=""modal"">Nie</a>
					<a id=""removeTrip"" class=""btn btn-primary"">Tak</a>
				</div>
");
            EndContext();
#line 60 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
			}
			else
			{

#line default
#line hidden
            BeginContext(2291, 209, true);
            WriteLiteral("\t\t\t\t<div class=\"modal-body\">\r\n\t\t\t\t\t<p>Byle człopok nie może usuwać wycieczek!</p>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"modal-footer\">\r\n\t\t\t\t\t<a class=\"btn btn-primary\" data-dismiss=\"modal\">Przepraszam</a>\r\n\t\t\t\t</div>\r\n");
            EndContext();
#line 69 "D:\nauka\GitHub\WodzitsuSite\WodzitsuSite\Views\App\Wakacje.cshtml"
			}

#line default
#line hidden
            BeginContext(2506, 25, true);
            WriteLiteral("\t\t</div>\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ScoreViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
