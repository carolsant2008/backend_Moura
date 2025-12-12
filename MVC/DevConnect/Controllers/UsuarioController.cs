using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DevConnect.Contexts;
using DevConnect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;

namespace DevConnect.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly DevConnectContext _context;
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger, DevConnectContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.UsuarioNovoCadastrado = "";
            TempData["UsuarioNovoCadastrado"] = "";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormCollection form)
        {
            TbUsuario novoUsuario = new TbUsuario()
            {
                NomeCompleto = form["NomeCompleto"].ToString(),
                NomeUsuario = form["NomeUsuario"].ToString(),
                Email = form["Email"].ToString(),
                Senha = form["Senha"].ToString()
            };

            if (form.Files.Count > 0)
            {
                IFormFile file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);

                }
                string path = Path.Combine(folder, file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                novoUsuario.FotoPerfilUrl = file.FileName;
            }
            else
            {
                novoUsuario.FotoPerfilUrl = "1000330022.jpg";
            }
            try
            {
                _context.TbUsuario.Add(novoUsuario);
                await _context.SaveChangesAsync();
                TempData["UsuarioNovoCadastrado"] = "Cadastrado";
                ViewBag.UsuarioNovoCadastrado = "";
                return RedirectToAction("Index", "Home");
            }
            catch (System.Exception)
            {
                ViewBag.UsuarioNovoCadastrado = "Nao cadastrado";
                TempData["UsuarioNovoCadastrado"] = "";
                return View();
            }

        }

        public IActionResult Perfil1()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}