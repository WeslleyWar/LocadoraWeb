using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocadoraWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraWeb.Controllers
{
    public class ClienteController : Controller
    {
        private readonly Context _context;

        public ClienteController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar() => View();
        [HttpPost]
        public IActionResult Cadastrar(string txtNome, int txtCPF, string txtEmail,
            string txtEndereço, int txtHabilitação, string txtCategoria, int txtTelefone)
        {
            return RedirectToAction("Index", "Cliente");
        }

        public IActionResult Remover(int id)
        {
            _context.Clientes.Remove(_context.Clientes.Find(id));
            _context.SaveChanges();
            return RedirectToAction("Index", "Cliente");
        }
        public IActionResult Alterar(int id)
        {
            ViewBag.Cliente = _context.Clientes.Find(id);
            return View();
        }

        [HttpPost]
        public IActionResult Alterar(int txtId, string txtNome, int txtCPF, string txtEmail,
            string txtEndereço, int txtHabilitação, string txtCategoria, int txtTelefone)
        {
            Cliente cliente = _context.Clientes.Find(txtId);

            cliente.Nome = txtNome;
            cliente.CPF = Convert.ToInt32(txtCPF);
            cliente.Email = txtEmail;
            cliente.Endereço = txtEndereço;
            cliente.Habilitação = Convert.ToInt32(txtHabilitação);
            cliente.Categoria = txtCategoria;
            cliente.Telefone = Convert.ToInt32(txtTelefone);
          

            _context.Clientes.Update(cliente);
            _context.SaveChanges();
            return RedirectToAction("Index", "Cliente");
        }

    }
}