using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LocadoraWeb.Models;
using LocadoraWeb.DAL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace LocadoraWeb.Controllers
{
    [Authorize]
    public class GaragemController : Controller
    {
        private readonly Context _context;
        private readonly GaragemDAO _garagemDAO;
        private readonly IWebHostEnvironment _hosting;

        public GaragemController(GaragemDAO garagemDAO, IWebHostEnvironment hosting)
        {
            _garagemDAO = garagemDAO;
            _hosting = hosting;
        }

        // GET: Garagem
        [Authorize(Roles = "Usuario")]
        public async Task<IActionResult> Index()
        {
            List<Garagem> garagens = _garagemDAO.Listar();
            ViewBag.Title = "Gerenciamento de Categorias";
            return View(garagens);
            //return View(await _context.Garagem.ToListAsync());
        }

        [Authorize(Roles = "Usuario")]
        public async Task<IActionResult> Lista()
        {
            List<Garagem> garagens = _garagemDAO.Listar();
            return View(garagens);
            //return View(await _context.Garagem.ToListAsync());
        }

        // GET: Garagem/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Cadastrar()
        {
            return View();
        }

        // POST: Garagem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cadastrar(string Nome, int Numero, string Cep, string Logradouro, string Bairro, string Localidade, string Uf)
        {
        Garagem garagem = new Garagem
            {
                Nome = Nome,
                Numero = Numero,
                Cep = Cep,
                Logradouro = Logradouro,
                Bairro = Bairro,
                Localidade = Localidade,
                Uf = Uf
            };
            _garagemDAO.Cadastrar(garagem);
            return RedirectToAction("Index", "Garagem");
        }

        // GET: Garagem/Delete/5
        [Authorize(Roles = "Admin")]
        public IActionResult Remover(int id)
        {
            _garagemDAO.Remover(id);
            return RedirectToAction("Index", "Garagem");
        }
    }
}
