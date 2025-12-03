using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers
{
    // [Route("[controller]")]
    // [Route("[controller]/[action]")]
    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;

        public static List<Fruta> listaDeFrutas = new List<Fruta>
        {
            new Fruta{ Id = 1, Nome = "Morango", Preco = 5.99f, Quantidade = 10, Categoria = "Tropical" },
            new Fruta{ Id = 2, Nome = "Abacate", Preco = 5.90f, Quantidade = 12, Categoria = "Tropical" },
            new Fruta{ Id = 3, Nome = "Limão", Preco = 2.95f, Quantidade = 100, Categoria = "Cítrica" },
        };

        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {


            return View();
        }

        [HttpGet]
        public IActionResult ListarFrutas()
        {

            ViewBag.sacolinha = listaDeFrutas;
            return View();
        }


        [HttpGet]
        // Mostra a tela de cadastrar
        public IActionResult Create()
        {
            return View();
        }

        // salvar a fruta na Lista de Frutas
        // Em seguida, redireciona para a lista/tela de ListarFrutas
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public IActionResult SalvarFruta(Fruta frutaCadastrada)
        {

            // criar um id novo
            frutaCadastrada.Id = listaDeFrutas.Max(f => f.Id) + 1;
            //salvar os dados da fruta na listaDeFrutas
            listaDeFrutas.Add(frutaCadastrada);
            // voltar para a tela de listagem de frutas
            return RedirectToAction(nameof(ListarFrutas));
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}