using System;
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

namespace BOVINE_WEIGHT.Controllers
{
    public class CadastroController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;
        private const int DefaultPageSize = 8;
        public CadastroController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
        public IActionResult IndexEmpresa()
        {
            Cadastro objConta = new Cadastro(HttpContextAccessor);
            ViewBag.ListaCadastro = objConta.ListaEmpresas();
            return View();
        }
        public IActionResult IndexProdutor(int? page, Cadastro formulario,
         String Pesquisar)
        {
            Cadastro objControler = new Cadastro(HttpContextAccessor);
            Cadastro objTransacao = new Cadastro(HttpContextAccessor);

            if (Validacoes.Pesquisar == "Sim")
            {
                page = Validacoes.Page;
                formulario = Validacoes.Formulario;
            }
            int LimitPage = 0;


            if (page == null || page == 1 || Validacoes.Pesquisar == "Sim")
            {
                page = 1;
                LimitPage = Convert.ToInt32(page) * 10;
            }
            else
            {
                LimitPage = Convert.ToInt32(page) * 10;
            }
            
            /// ViewBag.ListaCadastro = objConta.ListaProdutor()
            ViewBag.ListaCadastro = formulario.ListaFornecedores(LimitPage.ToString());

            Validacoes.TabelaPesquisa = "FORNECEDORES";
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
            model.Paging.TotalItems = TotalDeRegistros.Total;
            ViewBag.CurrentPage = page;
            ViewBag.ItemsPerPage = DefaultPageSize;
            ViewBag.TotalItems = TotalDeRegistros.Total;
            ViewBag.PageSize = DefaultPageSize;
            ViewBag.PageNumber = page;


            ViewBag.CurrentPage = page;

            //ViewBag.ListaCadastro = objConta.ListaProdutor();
            return View();
        }

        public IActionResult MenuCadastro()
        {
            return View();
        }

        public IActionResult RegistrarEmpresa(int ? id)
        {
            Cadastro objUf = new Cadastro(HttpContextAccessor);
            if (id != null)
            {
                Cadastro objTransacao = new Cadastro(HttpContextAccessor);
                ViewBag.Registro = objTransacao.CarregaRegistroEmpresa(id);
                ViewBag.Editar = "SIM";
            }

            ViewBag.ListaUf = objUf.ListaUf();
            return View();
        }
        public IActionResult RegistrarProdutores(int? id)
        {
            Cadastro objUf = new Cadastro(HttpContextAccessor);
            if (id != null)
            {
                Cadastro objTransacao = new Cadastro(HttpContextAccessor);
                ViewBag.Registro = objTransacao.CarregaRegistroProdutor(id);
                ViewBag.Editar = "SIM";
            }

            ViewBag.ListaUf = objUf.ListaUf();
            return View();
        }
        public IActionResult Registrar(Cadastro formulario)
        {
            formulario.HttpContextAccessor = HttpContextAccessor;
            var vUf = formulario.Pesquisa(formulario.Id_Uf,"ID_UF","SIGLA","UNIDADE_FEDERACAO");
            string ValorUF = vUf.CampoPesquisa + " - ";
            vUf = formulario.Pesquisa(formulario.Id_Uf, "ID_UF", "UNIDADE", "UNIDADE_FEDERACAO");
            ValorUF += vUf.CampoPesquisa;

            formulario.Insert(ValorUF.ToString());
            return RedirectToAction("IndexEmpresa");
            
        }
        public IActionResult RegistrarProdutor(Cadastro formulario)
        {
            formulario.HttpContextAccessor = HttpContextAccessor;
            var vUf = formulario.Pesquisa(formulario.Id_Uf, "ID_UF", "SIGLA", "UNIDADE_FEDERACAO");
            string ValorUF = vUf.CampoPesquisa + " - ";
            vUf = formulario.Pesquisa(formulario.Id_Uf, "ID_UF", "UNIDADE", "UNIDADE_FEDERACAO");
            ValorUF += vUf.CampoPesquisa;

            formulario.InsertProdutor(ValorUF.ToString());
            return RedirectToAction("IndexProdutor");

        }
        [HttpGet]
        public IActionResult ExcluirEmpresa(int Id)
        {
            Cadastro objTransacao = new Cadastro(HttpContextAccessor);
            objTransacao.Excluir(Id);
            return RedirectToAction("IndexEmpresa");
        }
        [HttpGet]
        public IActionResult ExcluirProdutor(int Id)
        {
            Cadastro objTransacao = new Cadastro(HttpContextAccessor);
            objTransacao.ExcluirProdutor(Id);
            return RedirectToAction("IndexProdutor");
        }
        [HttpGet]
        public IActionResult ExcluirRegistroEmpresa(int? Id)
        {
            Cadastro objTransacao = new Cadastro(HttpContextAccessor);
            ViewBag.Registro = objTransacao.CarregaRegistroEmpresa(Id);
            return View();
        }
        [HttpGet]
        public IActionResult ExcluirRegistroProdutor(int? Id)
        {
            Cadastro objTransacao = new Cadastro(HttpContextAccessor);
            ViewBag.Registro = objTransacao.CarregaRegistroProdutor(Id);
            return View();
        }
    }
}