#pragma checksum "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c432289b624e98812c0f301391cb83f8050e984"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastro_IndexProdutor), @"mvc.1.0.view", @"/Views/Cadastro/IndexProdutor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cadastro/IndexProdutor.cshtml", typeof(AspNetCore.Views_Cadastro_IndexProdutor))]
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
#line 2 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#line 3 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
using PagedList;

#line default
#line hidden
#line 4 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#line 5 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
using cloudscribe.Web.Pagination;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c432289b624e98812c0f301391cb83f8050e984", @"/Views/Cadastro/IndexProdutor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e344d6a3b1af09bc0d95163bd07c10782a689b", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadastro_IndexProdutor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cadastro>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/PagedList.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RegistrarProdutores", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pagenumber-param", "page", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-first-page-text", "Primeiro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-last-page-text", "Ultimo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-current-class", "active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-non-active-class", "disabled", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexProdutor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::cloudscribe.Web.Pagination.PagerTagHelper __cloudscribe_Web_Pagination_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(147, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(151, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4aee1c2fbf1f40f283cadfb8ea2dcb76", async() => {
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
            BeginContext(219, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
      
        ViewData["Title"] = "Produtor";
    

#line default
#line hidden
            BeginContext(277, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(407, 231, true);
            WriteLiteral("\r\n    <style>\r\n        body {\r\n            background-color: #81080A;\r\n        }\r\n    </style>\r\n\r\n    <div class=\"container\" style=\"background-color:rgba(239,239,239,0.95); border-radius:10px; padding:20px;width:1100px;\">\r\n        ");
            EndContext();
            BeginContext(638, 2058, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7546d8a00cb142458c116df883e0ce95", async() => {
                BeginContext(703, 509, true);
                WriteLiteral(@"
            <h3>Produtores</h3>
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>#</th>
                        <th>CÓDIGO</th>
                        <th>CNPJ/CPF</th>
                        <th>PRODUTOR</th>
                        <th>ENDEREÇO</th>
                        <th>CIDADE</th>
                        <th>UF</th>
                    </tr>
                </thead>
");
                EndContext();
#line 37 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
                  
                    foreach (var item in (List<Cadastro>)ViewBag.ListaCadastro)
                    {

#line default
#line hidden
                BeginContext(1336, 67, true);
                WriteLiteral("                        <tbody>\r\n                            <tr>\r\n");
                EndContext();
#line 42 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
                                  
                                    if (@item.Id != 0)
                                    {

#line default
#line hidden
                BeginContext(1534, 108, true);
                WriteLiteral("                                        <td style=\"width=50px\"><button type=\"button\" class=\"btn btn-success\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1642, "\"", 1679, 3);
                WriteAttributeValue("", 1652, "Editar(", 1652, 7, true);
#line 45 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
WriteAttributeValue("", 1659, item.Id.ToString(), 1659, 19, false);

#line default
#line hidden
                WriteAttributeValue("", 1678, ")", 1678, 1, true);
                EndWriteAttribute();
                BeginContext(1680, 130, true);
                WriteLiteral(">Editar</button></td>\r\n                                        <td style=\"width=50px\"><button type=\"button\" class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1810, "\"", 1856, 3);
                WriteAttributeValue("", 1820, "ExcluirRegistro(", 1820, 16, true);
#line 46 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
WriteAttributeValue("", 1836, item.Id.ToString(), 1836, 19, false);

#line default
#line hidden
                WriteAttributeValue("", 1855, ")", 1855, 1, true);
                EndWriteAttribute();
                BeginContext(1857, 87, true);
                WriteLiteral(">Excluir</button></td>\r\n                                        <td style=\"width=50px\">");
                EndContext();
                BeginContext(1945, 18, false);
#line 47 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
                                                          Write(item.Id.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(1963, 71, true);
                WriteLiteral("</td>\r\n                                        <td style=\"width=150px\">");
                EndContext();
                BeginContext(2035, 40, false);
#line 48 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
                                                           Write(item.CpfCnpj.ToString().PadLeft(18, ' '));

#line default
#line hidden
                EndContext();
                BeginContext(2075, 71, true);
                WriteLiteral("</td>\r\n                                        <td style=\"width=400px\">");
                EndContext();
                BeginContext(2147, 25, false);
#line 49 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
                                                           Write(item.Descricao.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(2172, 71, true);
                WriteLiteral("</td>\r\n                                        <td style=\"width=400px\">");
                EndContext();
                BeginContext(2244, 24, false);
#line 50 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
                                                           Write(item.Endereco.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(2268, 71, true);
                WriteLiteral("</td>\r\n                                        <td style=\"width=150px\">");
                EndContext();
                BeginContext(2340, 22, false);
#line 51 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
                                                           Write(item.Cidade.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(2362, 70, true);
                WriteLiteral("</td>\r\n                                        <td style=\"width=50px\">");
                EndContext();
                BeginContext(2433, 34, false);
#line 52 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
                                                          Write(item.Uf.ToString().Substring(0, 2));

#line default
#line hidden
                EndContext();
                BeginContext(2467, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 53 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
                                    }
                                

#line default
#line hidden
                BeginContext(2548, 69, true);
                WriteLiteral("                            </tr>\r\n                        </tbody>\r\n");
                EndContext();
#line 57 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
                    }
                

#line default
#line hidden
                BeginContext(2659, 30, true);
                WriteLiteral("            </table>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2696, 430, true);
            WriteLiteral(@"
    </div>

    <div class=""container"" style=""background-color:rgba(239,239,239,0.95); border-radius:10px; padding:20px;width:1100px;"">
        <table class=""table table-bordered"" align=""center"" style=""width:500px;"">
            <tbody>
                <tr>
                    <td style=""width:50px""><button type=""button"" class=""btn btn-block btn-primary"" onclick=""CriarRegistro()"">Criar Registro Produtor</button></td>
");
            EndContext();
#line 68 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
                     if (ViewBag.Editar == "SIM")
                    {

#line default
#line hidden
            BeginContext(3200, 150, true);
            WriteLiteral("                        <td style=\"width:50px\"><button type=\"button\" class=\"btn btn-block btn-primary\" onclick=\"VoltarEditar()\">Voltar</button></td>\r\n");
            EndContext();
#line 71 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3422, 144, true);
            WriteLiteral("                        <td style=\"width:50px\"><button type=\"button\" class=\"btn btn-block btn-primary\" onclick=\"Voltar()\">Voltar</button></td>\r\n");
            EndContext();
#line 75 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
                    }

#line default
#line hidden
            BeginContext(3589, 79, true);
            WriteLiteral("                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(3668, 800, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5cd18a331db46afa39f79a1fb5a05a4", async() => {
                BeginContext(3674, 29, true);
                WriteLiteral("\r\n        <div>\r\n            ");
                EndContext();
                BeginContext(3703, 732, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cs-pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d62aeb0b72b941f383fabc882e03e6ae", async() => {
                    BeginContext(4410, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                }
                );
                __cloudscribe_Web_Pagination_PagerTagHelper = CreateTagHelper<global::cloudscribe.Web.Pagination.PagerTagHelper>();
                __tagHelperExecutionContext.Add(__cloudscribe_Web_Pagination_PagerTagHelper);
#line 82 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageSize = 10;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagesize", __cloudscribe_Web_Pagination_PagerTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 83 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageNumber = ViewBag.CurrentPage;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagenumber", __cloudscribe_Web_Pagination_PagerTagHelper.PageNumber, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 84 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.TotalItems = ViewBag.TotalItems;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-totalitems", __cloudscribe_Web_Pagination_PagerTagHelper.TotalItems, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __cloudscribe_Web_Pagination_PagerTagHelper.PageNumberParam = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 86 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.ShowFirstLast = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("cs-show-first-last", __cloudscribe_Web_Pagination_PagerTagHelper.ShowFirstLast, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 87 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.SuppressEmptyNextPrev = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("cs-suppress-empty-nextprev", __cloudscribe_Web_Pagination_PagerTagHelper.SuppressEmptyNextPrev, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 88 "E:\Projetos\PESAGEM_BOI_VIVO\RAEC\RAEC_ASPNETCORE\BOVINE_WEIGHT\BOVINE_WEIGHT\Views\Cadastro\IndexProdutor.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.SuppressInActiveFirstLast = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("cs-suppress-inactive-firstlast", __cloudscribe_Web_Pagination_PagerTagHelper.SuppressInActiveFirstLast, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __cloudscribe_Web_Pagination_PagerTagHelper.FirstPageText = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __cloudscribe_Web_Pagination_PagerTagHelper.LastPageText = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __cloudscribe_Web_Pagination_PagerTagHelper.LiCurrentCssClass = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __cloudscribe_Web_Pagination_PagerTagHelper.LiNonActiveCssClass = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __cloudscribe_Web_Pagination_PagerTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __cloudscribe_Web_Pagination_PagerTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4435, 26, true);
                WriteLiteral("\r\n\r\n        </div>\r\n\r\n    ");
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
            BeginContext(4468, 518, true);
            WriteLiteral(@"

    <script>
        function CriarRegistro() {
            window.location.href = ""../Cadastro/RegistrarProdutores""
        }
        function Voltar() {
            window.location.href = ""../Home/Menu""
        }
        function ExcluirRegistro(id_conta) {
            window.location.href = ""../Cadastro/ExcluirRegistroProdutor/"" + id_conta;
        }
        function Editar(id_conta) {
            window.location.href = ""../Cadastro/RegistrarProdutores/"" + id_conta;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cadastro> Html { get; private set; }
    }
}
#pragma warning restore 1591
