using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PagedList;
using PagedList.Core.Mvc;
using cloudscribe.Web.Pagination;
using BOVINE_WEIGHT.Models;
using System.ComponentModel.DataAnnotations;
using BOVINE_WEIGHT.Util;
using Rotativa.AspNetCore;

namespace BOVINE_WEIGHT.Controllers
{
    public class MovimentoController : Controller
    {
        private IHttpContextAccessor httpContextAccessor;
        IHttpContextAccessor HttpContextAccessor;
        private const int DefaultPageSize = 5;
        public MovimentoController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
        [HttpGet]
        [HttpPost]
        public IActionResult VerMovimento(int? page, Cadastro formulario)
        {
            Validacoes.Pesquisar = "Sim";
            Validacoes.Page = Convert.ToInt16(page);
            Validacoes.Formulario = formulario;
            Validacoes.Data_Ini = DateTime.Parse(formulario.Data_Ini.ToString());
            Validacoes.Data_Fim = DateTime.Parse(formulario.Data_Fim.ToString());
            Validacoes.Excliur_Transacao = "S";
            return RedirectToAction("IndexMovimento");
        }
        public IActionResult PesquisarMovimento(int? id, int? page,Cadastro formulario,
         String Pesquisar)
        {
            
            MovimentoModel objTransacao = new MovimentoModel(HttpContextAccessor);
            MovimentoModel objAbate = new MovimentoModel(HttpContextAccessor);
            int LimitPage = 0;
           

            if (page != null)
                Validacoes.Page = int.Parse(page.ToString());
            else
                Validacoes.Page = 1;

            LimitPage = Convert.ToInt32(Validacoes.Page) * 5;

            formulario = Validacoes.Formulario;
           

            ViewBag.RegistroAbate = objTransacao.CarregaRegistroDadosAbate(id);
            ViewBag.ListaMovimentoAbate = objAbate.ListaMovAbate(LimitPage.ToString(), id);
            ViewBag.NrAbate = id;

            string TabelaPesquisa = "MOVIMENTACAO_ABATE";
            string CampoPesquisa = "ID";
            string Where = $" WHERE ID_ABATE={id} ";
            string CampoOrdem = "";

            var TotalDeRegistros = objAbate.TotalRegistrosMovimento
              (
              LimitPage,
              TabelaPesquisa,
              CampoPesquisa,
              Where,
              CampoOrdem);

            var model = new Paginacao();

            model.Paging.CurrentPage = long.Parse(Validacoes.Page.ToString());
            model.Paging.ItemsPerPage = DefaultPageSize;
            model.Paging.TotalItems = long.Parse(TotalDeRegistros.Total.ToString());

            ViewBag.CurrentPage = Validacoes.Page;
            ViewBag.ItemsPerPage = DefaultPageSize;
            ViewBag.TotalItems = long.Parse(TotalDeRegistros.Total.ToString());
            //ViewBag.PageSize = DefaultPageSize;
            //ViewBag.PageNumber = Validacoes.Page.ToString();
            ViewBag.PageSize = DefaultPageSize;
            ViewBag.PageNumber = Validacoes.Page.ToString();
           
          
            return View();
        }
        public IActionResult IndexMovimento(int? page, Cadastro formulario,
         String Pesquisar)
        {
            AbateModel objAbate = new AbateModel(HttpContextAccessor);

            
            
            int LimitPage = 0;
            if (page == null && Validacoes.Excliur_Transacao != "S")
            {
                Validacoes.Data_Ini = DateTime.Parse("01/" +
                            "01/" +
                            System.DateTime.Now.Year.ToString());
                Validacoes.Data_Fim = DateTime.Parse(System.DateTime.Now.ToString().Substring(0, 10));
            }


            if (Validacoes.Pesquisar == "Sim")
            {
                if (page!=null)
                 Validacoes.Page = int.Parse(page.ToString());

                formulario = Validacoes.Formulario;
            }



            if (page == null || Validacoes.Pesquisar == "Sim")
            {
                page = 1;
                LimitPage = 0;
                if (Validacoes.Excliur_Transacao == "S")
                {
                    Validacoes.Excliur_Transacao = "N";
                }
                else
                {
                    if (formulario.Data_Ini != null)
                    {
                        Validacoes.Data_Ini = DateTime.Parse(formulario.Data_Ini.ToString());
                    }
                    if (formulario.Data_Fim != null)
                    {
                        Validacoes.Data_Fim = DateTime.Parse(formulario.Data_Fim.ToString());
                    }
                }
                if (formulario == null)
                {
                    formulario = Validacoes.Formulario;
                }
                LimitPage = Convert.ToInt32(Validacoes.Page) * 5;



            }
            else
            {
                LimitPage = Convert.ToInt32(page) * 5;
                if (Validacoes.Excliur_Transacao == "S")
                {
                    Validacoes.Excliur_Transacao = "N";
                }
                else
                {
                    if (formulario.Data_Ini != null)
                    {
                        Validacoes.Data_Ini = DateTime.Parse(formulario.Data_Ini.ToString());
                    }
                    if (formulario.Data_Fim != null)
                    {
                        Validacoes.Data_Fim = DateTime.Parse(formulario.Data_Fim.ToString());
                    }
                }
                //if (formulario.Conta_Id == 0)
                //{
                //    Validacoes.Id_Conta = formulario.Conta_Id;
                //}
                //if (formulario.Plano_Conta_Id == 0)
                //{
                //    Validacoes.Id_Plano_Conta = formulario.Plano_Conta_Id;
                //}

            }
            LimitPage = Convert.ToInt32(Validacoes.Page) * 5;
           
            ViewBag.ListaAbate = objAbate.ListaAbate(LimitPage.ToString(), 
                DateTime.Parse(Validacoes.Data_Ini.ToString()),
                DateTime.Parse(Validacoes.Data_Fim.ToString()));

            Validacoes.TabelaPesquisa = "ABATE";
            Validacoes.CampoPesquisa = "ID";
            Validacoes.CampoOrdem = "ID";
            var model = new Paginacao();
            var TotalDeRegistros = formulario.TotalRegistros
                (
                LimitPage,
                Validacoes.Data_Ini,
                Validacoes.Data_Fim,
                Validacoes.TabelaPesquisa,
                Validacoes.CampoPesquisa,
                Validacoes.CampoOrdem);

            model.Paging.CurrentPage = long.Parse(page.ToString());
            model.Paging.ItemsPerPage = DefaultPageSize;
            model.Paging.TotalItems = long.Parse(TotalDeRegistros.Total.ToString());

            ViewBag.Data1 = Validacoes.Data_Ini;
            ViewBag.Data2 = Validacoes.Data_Fim;

            ViewBag.CurrentPage = Validacoes.Page;
            ViewBag.ItemsPerPage = DefaultPageSize;
            ViewBag.TotalItems = long.Parse(TotalDeRegistros.Total.ToString());
            ViewBag.PageSize = DefaultPageSize;
            ViewBag.PageNumber = page;
            ViewBag.PageSize = DefaultPageSize;
            ViewBag.PageNumber = page;
            return View();
        }
        [HttpPost]
        public IActionResult GerarPdf(MovimentoModel formulario)
        {
            formulario.HttpContextAccessor = HttpContextAccessor;
            ViewBag.ListaMapaFinanceiro = formulario.ListaMovimentacaoAbate();

            //ViewBag.ListaContas = new ContaModel(HttpContextAccpublic IActionResult VisualizarComoPDF()
            return new ViewAsPdf("VisualizarComoPDF");

        }
        public IActionResult VisualizarComoPDF(MovimentoModel formulario)
        {

            formulario.HttpContextAccessor = HttpContextAccessor;
            string footer = "--footer-center \"Gerado em: " + DateTime.Now.Date.ToString("dd/MM/yyyy") + "  Page: [page]/[toPage]\"" + " --footer-line --footer-font-size \"9\" --footer-spacing 6 --footer-font-name \"calibri light\"";

            AbateModel objAbate = new AbateModel(HttpContextAccessor);

            var Registro = objAbate.CarregaRegistroAbate(int.Parse(Validacoes.Codigo_Abate));

            string header = "--print-media-type --header-font-size \"7\" --header-left " +
                "\"==========================================================================================\n" +
                "                                                   ABATES REALIZADOS \n" +
                "==========================================================================================\n" +
                "NR ABATE           " + Validacoes.Codigo_Abate.PadLeft(5,'0') + "\n" +
                "EMPRESA          : " + Registro.Nome_Empresa+"\n"+
                "FORNECEDOR  : " + Registro.Nome_Produtor + "\n" +
                "QUANTIDADE    :  "+Registro.Quantidade.ToString().PadLeft(5,'0') + "   DATA :   "+Registro.Data_Abate +"\n"+
                "==========================================================================================\n" +
                " CODIGO            DATA                                     TAG                   " +
                "                                         PESO \n"+
                "==========================================================================================\n" +
                "\"";
            
            
            
            var relatorioPDF = new ViewAsPdf
            {
                ViewName = "VisualizarComoPDF",
                FileName = @"\RELATORIOABATE" + DateTime.Now.Date.ToString("MM/dd/yyyy HH:MM:SS") + ".PDF",
                IsGrayScale = true,
                MinimumFontSize = 10,
                CustomSwitches = footer+" "+header,
                Model = formulario.ListaMovimentacaoAbate()
            };
            return relatorioPDF;

        }
    }
}