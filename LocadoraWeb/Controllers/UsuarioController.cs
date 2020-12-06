using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LocadoraWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace LocadoraWeb.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly Context _context;
        private readonly UserManager<Usuario> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<Usuario> _signInManager;

        //public UsuarioController(Context context, UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        //{
        //    _context = context;
        //    _userManager = userManager;
        //    _signInManager = signInManager;
        //}

        public UsuarioController(Context context, UserManager<Usuario> userManager, SignInManager<Usuario> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        // GET: Usuario
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuarios.ToListAsync());
        }

        // GET: Usuario/Create
        public IActionResult Cadastrar()
        {
            return View();
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cadastrar(UsuarioView usuarioView)
        {
            if (ModelState.IsValid)
            {
                Usuario usuario = new Usuario
                {
                    UserName = usuarioView.Email,
                    Email = usuarioView.Email,
                    Perfil = usuarioView.Perfil,
                    //Endereço
                    Cep = usuarioView.Cep,
                    Logradouro = usuarioView.Logradouro,
                    Bairro = usuarioView.Bairro,
                    Localidade = usuarioView.Localidade,
                    Uf = usuarioView.Uf,
                    Numero = usuarioView.Numero,
                    //Dados pessoais
                    Nome = usuarioView.Nome,
                    Genero = usuarioView.Genero,
                    Profissao = usuarioView.Profissao,
                    AnoNasc = usuarioView.AnoNasc,
                    Cnh = usuarioView.Cnh,
                    Cpf = usuarioView.Cpf,
                    Telefone = usuarioView.Telefone
                };

                IdentityResult resultado = await _userManager.CreateAsync(usuario, usuarioView.Senha);
                if (resultado.Succeeded)
                {
                    var applicationRole = await _roleManager.FindByNameAsync(usuario.Perfil);
                    if (applicationRole != null)
                    {
                        IdentityResult roleResult = await _userManager.AddToRoleAsync(usuario, applicationRole.Name);

                        _context.Add(usuarioView);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                }
                AdicionarErros(resultado);
            }
            return View(usuarioView);
        }

        public void AdicionarErros(IdentityResult resultado)
        {
            foreach (IdentityError erro in resultado.Errors)
            {
                ModelState.AddModelError("", erro.Description);
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        //Login
        [HttpPost]
        public async Task<IActionResult> Login([Bind ("Email, Senha")] UsuarioView usuarioView)
        {
            var result = await _signInManager.PasswordSignInAsync(usuarioView.Email, usuarioView.Senha, false, false);
            return RedirectToAction("Index", "Home");
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Veiculo");
            }
            ModelState.AddModelError("", "Os dados não conferem!");
            return View(usuarioView);
        }

        //Logout
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
