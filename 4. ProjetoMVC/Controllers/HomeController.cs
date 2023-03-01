using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _4._ProjetoMVC.Models.ViewModels;

namespace _4._ProjetoMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        bool temErro = false;

        if (temErro)
        {
            ViewData["Controle"] = "Dado vindo do controle";
            var erro = new ErrorViewModel();
            erro.RequestId = "Errr";
            return View("Error", erro);
        }
        else
        {
            ViewData["Message"] = "Sales Web MVC App from C# Course";
            ViewData["Professor"] = "Fulano de Tal";
            return View();
        }
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
