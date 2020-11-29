using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocadoraWeb.DAL;
using LocadoraWeb.Models;
using LocadoraWeb.Utils;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly VeiculoDAO _veiculoDAO;
        private readonly CategoriaDAO _categoriaDAO;
        private readonly ItemLocacaoDAO _itemLocacaoDAO;
        private readonly Sessao _sessao;

        public HomeController(VeiculoDAO veiculoDAO, CategoriaDAO categoriaDAO, ItemLocacaoDAO itemLocacaoDAO, Sessao sessao)
        {
            _veiculoDAO = veiculoDAO;
            _categoriaDAO = categoriaDAO;
            _itemLocacaoDAO = itemLocacaoDAO;
            _sessao = sessao;
        }
        public IActionResult Index(int id)
        {
            ViewBag.Title = "Locadora Web";
            ViewBag.Categorias = _categoriaDAO.Listar();

            if(id == 0)
            {
                return View(_veiculoDAO.Listar());
            }
            return View(_veiculoDAO.ListarPorCategoria(id));
        }

        public IActionResult Locar(int id)
        {
            Categoria categoria = _categoriaDAO.BuscarPorId(id);
            Veiculo veiculo = _veiculoDAO.BuscarPorId(id);
            
            ItemLocacao item = new ItemLocacao
            {
                Veiculo = veiculo,
                Preco = veiculo.Categoria.valorDiaria,
                CarrinhoId = _sessao.BuscarCarrinhoId()
                //QntdDiasLocacao = item.QntdDiasLocacao
            };
            _itemLocacaoDAO.Cadastrar(item);
            return RedirectToAction("Confirmacao");
        }
        public IActionResult Confirmacao()
        {
            string auxCarrinhoId = _sessao.BuscarCarrinhoId();
            return View(_itemLocacaoDAO.ListarPorCarrinhoId(auxCarrinhoId));
        }
    }
}
