using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //ação padrão inicial
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult MinhaAcao()
    {
        //retorne a página MinhaAcao.cshtml
        return View();
    }

    public IActionResult ListarNomes()
    {   
        // Cria um array de nomes já preenchido
        string[] nomes = {"Eduardo", "Maria", "João", "Kauã", "Milena", "Rafaela"};
        ViewBag.Teste = "Olá, eu vim através da Viewbag";
        ViewBag.nomes = nomes;//guarda os nomes na viewbag

        return View();//chama a view passando os dados
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}