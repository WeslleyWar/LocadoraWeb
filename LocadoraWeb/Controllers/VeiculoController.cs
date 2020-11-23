using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraWeb.Controllers
{
    public class VeiculoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar() => View();
        [HttpPost]
        public IActionResult Cadastrar(string txtMarca, string txtModelo, string txtPlaca, 
            string txtRenavan, string txtTipoCategoria, string txtTipoCombustivel, string txtCor, 
            int txtQntdPortas, int txtAno, double txtPotencia)
        {
               return RedirectToAction("Index", "Veiculo");
        }

    }
}
