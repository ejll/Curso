using Quiron.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private ProdutosRepositorio produtosRepositorio;

        public ActionResult Index()
        {
            produtosRepositorio = new ProdutosRepositorio();
            var produtos = produtosRepositorio.Produtos;
            return View(produtos);
        }
    }
}