using Microsoft.AspNetCore.Mvc;

namespace SeuProjeto.Controllers
{
    public class TesteController : Controller
    {
        // /Teste/Index
        public IActionResult Index()
        {
            ViewBag.Titulo = "Página Inicial - Index";
            return View();
        }

        // /Teste/Listar
        public IActionResult Listar()
        {
            ViewBag.Titulo = "Página de Listagem";
            return View();
        }

        // /Teste/Cadastrar
        public IActionResult Cadastrar()
        {
            ViewBag.Titulo = "Página de Cadastro";
            return View();
        }

        // /Teste/Editar
        public IActionResult Editar()
        {
            ViewBag.Titulo = "Página de Edição";
            return View();
        }
    }
}
