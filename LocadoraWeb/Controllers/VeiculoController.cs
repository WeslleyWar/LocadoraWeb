using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocadoraWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraWeb.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly Context _context;

       public VeiculoController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Veiculo> veiculos = _context.Veiculos.ToList();
            ViewBag.Veiculos = veiculos;
            ViewBag.Quantidade = veiculos.Count;
            return View();
        }

        public IActionResult Cadastrar() => View();
        [HttpPost]
        public IActionResult Cadastrar(string txtMarca, string txtModelo, string txtPlaca, 
            string txtRenavan, string txtTipoCategoria, string txtTipoCombustivel, string txtCor, 
            int txtQntdPortas, int txtAno, double txtPotencia)
        {
            Veiculo veiculo = new Veiculo
            {
                Marca = txtMarca,
                Modelo = txtModelo,
                Placa = txtPlaca,
                Renavan = txtRenavan,
                TipoCategoria = txtTipoCategoria,
                TipoCombustivel = txtTipoCombustivel,
                Cor = txtCor,
                QntdPortas = Convert.ToInt32(txtQntdPortas),
                Ano = Convert.ToInt32(txtAno),
                Potencia = Convert.ToDouble(txtPotencia)
            };
            _context.Veiculos.Add(veiculo);
            _context.SaveChanges();
               return RedirectToAction("Index", "Veiculo");
        }
        public IActionResult Remover(int id)
        {
            //Falta criar o metodo para remover
            return RedirectToAction("Index", "Veiculo");
        }
    }
}
