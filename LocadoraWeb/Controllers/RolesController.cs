using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocadoraWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraWeb.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RolesController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Cadastrar(Roles role)
        {
            var roleExistente = await roleManager.RoleExistsAsync(role.RoleNome);
            if (!roleExistente)
            {
                var resultado = await roleManager.CreateAsync(new IdentityRole(role.RoleNome));
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
