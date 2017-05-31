using EntityFrameWork;
using Exemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exemplo.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult Cadastro(Produto produto)
        {

            ProdutoServico servico = new ProdutoServico();
            Entidade.Produto produtoTabela = new Entidade.Produto();

            produtoTabela.Nome = produto.Nome;
            produtoTabela.Categoria = produto.Categoria;

            servico.Cadastro(produtoTabela);


            return View();
        }
    }
}