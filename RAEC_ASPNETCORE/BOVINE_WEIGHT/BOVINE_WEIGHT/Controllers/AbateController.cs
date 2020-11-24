using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PagedList;
using PagedList.Core.Mvc;
using BOVINE_WEIGHT.Models;
using System.ComponentModel.DataAnnotations;
using BOVINE_WEIGHT.Util;

namespace BOVINE_WEIGHT.Controllers
{
    public class AbateController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;
        private const int DefaultPageSize = 8;
        public AbateController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public IActionResult RegistrarAbate(int? id)
        {
            AbateModel obj = new AbateModel(HttpContextAccessor);
            if (id != null)
            {
                AbateModel objTransacao = new AbateModel(HttpContextAccessor);
                ViewBag.Registro = objTransacao.CarregaRegistroAbate(id);
                ViewBag.Editar = "SIM";
            }
            ViewBag.ListaEmpresas = obj.ListaEmpresas();
            ViewBag.ListaProdutores = obj.ListaProdutor();
            return View();
        }
        public IActionResult Registrar(AbateModel formulario)
        {
            formulario.HttpContextAccessor = HttpContextAccessor;
            formulario.Insert();
            return RedirectToAction("IndexAbate");

        }
        [HttpGet]
        [HttpPost]
        public IActionResult VerMovimentoAbate(int? page, Cadastro formulario)
        {
            Validacoes.Pesquisar = "Sim";
            Validacoes.Page = Convert.ToInt16(page);
            Validacoes.Formulario = formulario;
            Validacoes.Data_Ini = DateTime.Parse(formulario.Data_Ini.ToString());
            Validacoes.Data_Fim = DateTime.Parse(formulario.Data_Fim.ToString());
            Validacoes.Excliur_Transacao = "S";
            return RedirectToAction("IndexAbate");
        }
        public IActionResult IndexAbate(int? page, Cadastro formulario,
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
        [HttpGet]
        public IActionResult ExcluirRegistroAbate(int? Id)
        {
            AbateModel objTransacao = new AbateModel(HttpContextAccessor);
            ViewBag.Registro = objTransacao.CarregaRegistroAbate(Id);
            return View();
        }
        [HttpGet]
        public IActionResult ExcluirAbate(int Id)
        {
            AbateModel objTransacao = new AbateModel(HttpContextAccessor);
            objTransacao.ExcluirAbate(Id);
            return RedirectToAction("IndexAbate");
        }
    }
}