using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LocadoraWeb.Models;
using Microsoft.AspNetCore.Authorization;
using LocadoraWeb.DAL;
using Microsoft.AspNetCore.Hosting;

namespace LocadoraWeb.Controllers
{
    //[Authorize(Roles = "ADM")]
    [Authorize]
    public class CategoriaController : Controller
    {
        //private readonly Context _context;
        private readonly CategoriaDAO _categoriaDAO;
        private readonly IWebHostEnvironment _hosting;

        public CategoriaController(CategoriaDAO categoriaDAO, IWebHostEnvironment hosting)
        {
            _categoriaDAO = categoriaDAO;
            _hosting = hosting;
        }

        // GET: Categoria
        [Authorize]
        public async Task<IActionResult> Index()
        {
            List<Categoria> categorias = _categoriaDAO.Listar();
            ViewBag.Title = "Gerenciamento de Categorias";
            return View(categorias);
        }

        // GET: Categoria/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult Cadastrar(string Nome, string Descricao, double valorDiaria)
        {
            Categoria categoria = new Categoria
            {
                Nome = Nome,
                Descricao = Descricao,
                valorDiaria = valorDiaria
            };
            _categoriaDAO.Cadastrar(categoria);
            return RedirectToAction("Index", "Categoria");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Remover(int id)
        {
            _categoriaDAO.Remover(id);
            return RedirectToAction("Index", "Categoria");
        }
    }
}
