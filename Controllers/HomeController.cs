using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using faegtodo.Models;

namespace faegtodo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.nome = "Walter";
            ViewData["sobrenome"] = "Coan";
            //return Redirect("https://www.univille.br");
            //return Content("<h1>Isso é muito feio...</h1>");
            //return NotFound("Voce não vai achar nada aqui...");

            //var novoTeste = new Teste();
            //novoTeste.Nome = "Zezinho da Silva!";
            //return View(novoTeste);
            return View();
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
}
