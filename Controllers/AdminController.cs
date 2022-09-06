using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AvaliacaoLP3.Models;
using AvaliacaoLP3.ViewModels;

namespace AvaliacaoLP3.Controllers;

public class AdminController : Controller
{
    private static List<Shopping> stores = new List<Shopping>
    {
        new Shopping(1, "Piso 2", "Leitura", "Entre no mundo dos livros e conheça outros milhares mundos!", "Loja", "leitura@hotmail.com"),
        new Shopping(2, "Piso 1", "Kalunga", "Os mais diversos materiais que você precisa!", "Loja", "kalunga@hotmail.com"),
        new Shopping(33, "Piso 3", "Mr Cheney", "Os cookies americanos originais mais deliciosos para você se deliciar!", "Kiosk", "mrcheney@hotmail.com"),
    }; //fazer classe separada só para passar esse valores, ao invés de repetir aqui e no user

    public IActionResult Index()
    {
        return View(stores);
    }
    
    public IActionResult Show(int id)
    {
        return View(stores[id-1]);
    }

    //public void Delete(int id)
    //{
    //    stores[id] = null;
    //}

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}