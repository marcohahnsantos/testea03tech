#pragma checksum "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fa6ee4231cef0fa11dd8db510931e0b94a438f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Abate_IndexAbate), @"mvc.1.0.view", @"/Views/Abate/IndexAbate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Abate/IndexAbate.cshtml", typeof(AspNetCore.Views_Abate_IndexAbate))]
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
#line 1 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\_ViewImports.cshtml"
using BOVINE_WEIGHT;

#line default
#line hidden
#line 2 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\_ViewImports.cshtml"
using BOVINE_WEIGHT.Models;

#line default
#line hidden
#line 2 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#line 3 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
using PagedList;

#line default
#line hidden
#line 4 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#line 5 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
using cloudscribe.Web.Pagination;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fa6ee4231cef0fa11dd8db510931e0b94a438f7", @"/Views/Abate/IndexAbate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e344d6a3b1af09bc0d95163bd07c10782a689b", @"/Views/_ViewImports.cshtml")]
    public class Views_Abate_IndexAbate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AbateModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/PagedList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Abate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VerMovimentoAbate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RegistrarAbate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pagenumber-param", "page", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-first-page-text", "Primeiro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-last-page-text", "Ultimo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-current-class", "active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-non-active-class", "disabled", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexAbate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::cloudscribe.Web.Pagination.PagerTagHelper __cloudscribe_Web_Pagination_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(149, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 9 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
  
    ViewData["Title"] = "Criar Abate";

#line default
#line hidden
            BeginContext(314, 74, true);
            WriteLiteral("<style>\r\n    body {\r\n        background-color: #81080A;\r\n    }\r\n</style>\r\n");
            EndContext();
            BeginContext(388, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a334e1d924674d07aa7bfb6d494916dc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(456, 131, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\" style=\"background-color:rgba(239,239,239,0.95); border-radius:10px; padding:20px;width:1100px;\">\r\n    ");
            EndContext();
            BeginContext(587, 854, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5640b639a2bb43d980f8d435d7a2b554", async() => {
                BeginContext(647, 122, true);
                WriteLiteral("\r\n        <h2>Meus Abates</h2>\r\n        <div class=\"form-group\">\r\n            <label>Data  (Inicio):</label>\r\n            ");
                EndContext();
                BeginContext(769, 106, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "27a82ab0f928470fb189f5bfa27d25f7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 30 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Data_Ini);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 30 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
                                                                 WriteLiteral(ViewBag.Data1.ToString("yyyy-MM-dd"));

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(875, 58, true);
                WriteLiteral("\r\n            <label>Data   (Final):</label>\r\n            ");
                EndContext();
                BeginContext(933, 106, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "487fa3d4ee024dad98e49acef64b12c1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 32 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Data_Fim);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 32 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
                                                                 WriteLiteral(ViewBag.Data2.ToString("yyyy-MM-dd"));

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1039, 395, true);
                WriteLiteral(@"


        </div>
        <div class=""container"" style=""background-color:rgba(239,239,239,0.95); border-radius:5px; padding:5px;width:200px;"">
            <tbody>
                <tr>
                    <td style=""width:50px"" ;height=""15px""><button type=""submit"" class=""btn btn-block btn-success"">Pesquisar</button></td>
                </tr>
            </tbody>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1441, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(1449, 1861, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ceb3c990ee354726946d385c8748d13e", async() => {
                BeginContext(1506, 429, true);
                WriteLiteral(@"
        <h3>Produtores</h3>
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>#</th>
                    <th>CÓDIGO</th>
                    <th>EMPRESA</th>
                    <th>PRODUTOR</th>
                    <th>QUANT. ANIMAIS</th>
                    <th>DATA ABATE</th>
                </tr>
            </thead>
");
                EndContext();
#line 59 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
              

                foreach (var item in (List<AbateModel>)ViewBag.ListaAbate)
                {

#line default
#line hidden
                BeginContext(2048, 59, true);
                WriteLiteral("                    <tbody>\r\n                        <tr>\r\n");
                EndContext();
#line 65 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
                              
                                if (@item.Id != 0)
                                {

#line default
#line hidden
                BeginContext(2226, 104, true);
                WriteLiteral("                                    <td style=\"width=50px\"><button type=\"button\" class=\"btn btn-success\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2330, "\"", 2367, 3);
                WriteAttributeValue("", 2340, "Editar(", 2340, 7, true);
#line 68 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
WriteAttributeValue("", 2347, item.Id.ToString(), 2347, 19, false);

#line default
#line hidden
                WriteAttributeValue("", 2366, ")", 2366, 1, true);
                EndWriteAttribute();
                BeginContext(2368, 126, true);
                WriteLiteral(">Editar</button></td>\r\n                                    <td style=\"width=50px\"><button type=\"button\" class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2494, "\"", 2540, 3);
                WriteAttributeValue("", 2504, "ExcluirRegistro(", 2504, 16, true);
#line 69 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
WriteAttributeValue("", 2520, item.Id.ToString(), 2520, 19, false);

#line default
#line hidden
                WriteAttributeValue("", 2539, ")", 2539, 1, true);
                EndWriteAttribute();
                BeginContext(2541, 83, true);
                WriteLiteral(">Excluir</button></td>\r\n                                    <td style=\"width=50px\">");
                EndContext();
                BeginContext(2625, 18, false);
#line 70 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
                                                      Write(item.Id.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(2643, 67, true);
                WriteLiteral("</td>\r\n                                    <td style=\"width=250px\">");
                EndContext();
                BeginContext(2711, 42, false);
#line 71 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
                                                       Write(item.id_Empresa.ToString().PadLeft(5, '0'));

#line default
#line hidden
                EndContext();
                BeginContext(2753, 1, true);
                WriteLiteral("-");
                EndContext();
                BeginContext(2755, 28, false);
#line 71 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
                                                                                                   Write(item.Nome_Empresa.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(2783, 67, true);
                WriteLiteral("</td>\r\n                                    <td style=\"width=250px\">");
                EndContext();
                BeginContext(2851, 43, false);
#line 72 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
                                                       Write(item.id_Produtor.ToString().PadLeft(5, '0'));

#line default
#line hidden
                EndContext();
                BeginContext(2894, 1, true);
                WriteLiteral("-");
                EndContext();
                BeginContext(2896, 29, false);
#line 72 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
                                                                                                    Write(item.Nome_Produtor.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(2925, 67, true);
                WriteLiteral("</td>\r\n                                    <td style=\"width=150px\">");
                EndContext();
                BeginContext(2993, 26, false);
#line 73 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
                                                       Write(item.Quantidade.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(3019, 67, true);
                WriteLiteral("</td>\r\n                                    <td style=\"width=150px\">");
                EndContext();
                BeginContext(3087, 26, false);
#line 74 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
                                                       Write(item.Data_Abate.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(3113, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 75 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
                                }
                            

#line default
#line hidden
                BeginContext(3186, 61, true);
                WriteLiteral("                        </tr>\r\n                    </tbody>\r\n");
                EndContext();
#line 79 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
                }
            

#line default
#line hidden
                BeginContext(3281, 22, true);
                WriteLiteral("        </table>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3310, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(3320, 1676, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de2149c629c742169bea3254b1e9ccc3", async() => {
                BeginContext(3326, 413, true);
                WriteLiteral(@"
    <div class=""container"" style=""background-color:rgba(239,239,239,0.95); border-radius:10px; padding:20px;width:1100px;"">
        <table class=""table table-bordered"" align=""center"" style=""width:500px;"">
            <tbody>
                <tr>
                    <td style=""width:50px""><button type=""button"" class=""btn btn-block btn-primary"" onclick=""CriarRegistro()"">Criar Registro Abate</button></td>
");
                EndContext();
#line 90 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
                     if (ViewBag.Editar == "SIM")
                    {

#line default
#line hidden
                BeginContext(3813, 150, true);
                WriteLiteral("                        <td style=\"width:50px\"><button type=\"button\" class=\"btn btn-block btn-primary\" onclick=\"VoltarEditar()\">Voltar</button></td>\r\n");
                EndContext();
#line 93 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(4035, 144, true);
                WriteLiteral("                        <td style=\"width:50px\"><button type=\"button\" class=\"btn btn-block btn-primary\" onclick=\"Voltar()\">Voltar</button></td>\r\n");
                EndContext();
#line 97 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
                    }

#line default
#line hidden
                BeginContext(4202, 96, true);
                WriteLiteral("                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(4298, 673, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cs-pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "282bc22807514b78906ec0743394435b", async() => {
                    BeginContext(4950, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __cloudscribe_Web_Pagination_PagerTagHelper = CreateTagHelper<global::cloudscribe.Web.Pagination.PagerTagHelper>();
                __tagHelperExecutionContext.Add(__cloudscribe_Web_Pagination_PagerTagHelper);
#line 104 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageSize = 5;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagesize", __cloudscribe_Web_Pagination_PagerTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 105 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageNumber = ViewBag.CurrentPage;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagenumber", __cloudscribe_Web_Pagination_PagerTagHelper.PageNumber, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 106 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.TotalItems = ViewBag.TotalItems;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-totalitems", __cloudscribe_Web_Pagination_PagerTagHelper.TotalItems, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __cloudscribe_Web_Pagination_PagerTagHelper.PageNumberParam = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
#line 108 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.ShowFirstLast = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("cs-show-first-last", __cloudscribe_Web_Pagination_PagerTagHelper.ShowFirstLast, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 109 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.SuppressEmptyNextPrev = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("cs-suppress-empty-nextprev", __cloudscribe_Web_Pagination_PagerTagHelper.SuppressEmptyNextPrev, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 110 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Abate\IndexAbate.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.SuppressInActiveFirstLast = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("cs-suppress-inactive-firstlast", __cloudscribe_Web_Pagination_PagerTagHelper.SuppressInActiveFirstLast, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __cloudscribe_Web_Pagination_PagerTagHelper.FirstPageText = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __cloudscribe_Web_Pagination_PagerTagHelper.LastPageText = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __cloudscribe_Web_Pagination_PagerTagHelper.LiCurrentCssClass = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __cloudscribe_Web_Pagination_PagerTagHelper.LiNonActiveCssClass = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                __cloudscribe_Web_Pagination_PagerTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __cloudscribe_Web_Pagination_PagerTagHelper.Action = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4971, 18, true);
                WriteLiteral("\r\n\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4996, 444, true);
            WriteLiteral(@"

<script>
    function CriarRegistro() {
        window.location.href = ""../Abate/RegistrarAbate""
    }
    function Voltar() {
        window.location.href = ""../Home/Menu""
    }
    function ExcluirRegistro(id_conta) {
        window.location.href = ""../Abate/ExcluirRegistroAbate/"" + id_conta;
    }
    function Editar(id_conta) {
        window.location.href = ""../Abate/RegistrarAbate/"" + id_conta;
    }
</script>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AbateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
