using Microsoft.AspNetCore.Mvc;
using SeuProjeto.Models;
using System.Collections.Generic;

namespace SeuProjeto.Controllers
{
    public class AlunoController : Controller
    {
        private static List<Aluno> alunos = new List<Aluno>();

       
        public IActionResult Index()
        {
            return View();
        }

       
        public IActionResult ListarAlunos()
        {
            return View(alunos);
        }

       
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                alunos.Add(aluno);
                return RedirectToAction("ListarAlunos");
            }

            return View(aluno);
        }
    }
}
