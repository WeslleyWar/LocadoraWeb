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
        public async Task<IActionResult> Index()
        {
            List<Categoria> categorias = _categoriaDAO.Listar();
            ViewBag.Title = "Gerenciamento de Categorias";
            return View(categorias);
        }       

        // GET: Categoria/Create
        public IActionResult Cadastrar()
        {
            return View();
        }

        // POST: Categoria/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Cadastrar([Bind("Nome,valorDiaria,Descricao,Id,CriadoEm")] Categoria categoria)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(categoria);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(categoria);
        //}

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

        public IActionResult Remover(int id)
        {
            _categoriaDAO.Remover(id);
            return RedirectToAction("Index", "Categoria");
        }

        //private bool CategoriaExists(int id)
        //{
        //    return _context.Categorias.Any(e => e.Id == id);
        //}
    }
}
