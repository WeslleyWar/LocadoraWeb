using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LocadoraWeb.DAL;
using LocadoraWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LocadoraWeb.Controllers
{
    //[Authorize] > Faz com que a action/controller necessite de uma autorização(estar logado) para ser acessado.
    //[Authorize(Roles = "ADM")] > Faz com que somente usuario logados e autorizados como ADM possam acessar a função.
   // [Authorize(Roles = "ADM")]
    public class VeiculoController : Controller
    {
       private readonly VeiculoDAO _veiculoDAO;
       private readonly CategoriaDAO _categoriaDAO;
       private readonly IWebHostEnvironment _hosting;

       public VeiculoController(VeiculoDAO veiculoDAO, IWebHostEnvironment hosting, CategoriaDAO categoriaDAO)
        {
            _veiculoDAO = veiculoDAO;
            _categoriaDAO = categoriaDAO;
            _hosting = hosting;
        }

        public IActionResult Index()
        {
            List<Veiculo> veiculos = _veiculoDAO.Listar();
            ViewBag.Title = "Gerenciamento de Veículos";
            ViewBag.Quantidade = veiculos.Count;
            return View(veiculos);
        }

        public IActionResult Cadastrar()
        {
            ViewBag.Categorias = new SelectList(_categoriaDAO.Listar(), "Id", "Nome");
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Veiculo veiculo, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    string arquivo = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
                    string caminho = Path.Combine(_hosting.WebRootPath, "images", arquivo);
                    file.CopyTo(new FileStream(caminho, FileMode.CreateNew));
                    veiculo.Imagem = arquivo;
                }
                else
                {
                    veiculo.Imagem = "semImagem.jpg";
                }

                veiculo.Categoria = _categoriaDAO.BuscarPorId(veiculo.CategoriaId);

                if (_veiculoDAO.Cadastrar(veiculo))
                {
                    return RedirectToAction("Index", "Veiculo");
                }
                ModelState.AddModelError("", "Não foi possivel cadastrar esse veículo.Placa já existente!");
            }
            ViewBag.Categorias = new SelectList(_categoriaDAO.Listar(), "Id", "Nome");
            return View();   
        }
        public IActionResult Remover(int id)
        {
            _veiculoDAO.Remover(id);
            return RedirectToAction("Index", "Veiculo");
        }

        public IActionResult Alterar(int id)
        {
            ViewBag.Categorias = new SelectList(_categoriaDAO.Listar(), "Id", "Nome");
            return View(_veiculoDAO.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Alterar(Veiculo veiculo, IFormFile file)
        {

            if (file != null)
            {
                string arquivo = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
                string caminho = Path.Combine(_hosting.WebRootPath, "images", arquivo);
                file.CopyTo(new FileStream(caminho, FileMode.CreateNew));
                veiculo.Imagem = arquivo;
            }
            else
            {
                veiculo.Imagem = "semImagem.jpg";
            }
            _veiculoDAO.Alterar(veiculo);
            ViewBag.Categorias = new SelectList(_categoriaDAO.Listar(), "Id", "Nome");
            return RedirectToAction("Index", "Veiculo");
        }

    }
}
