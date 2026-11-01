using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Tienda.Models;

namespace Tienda.Controllers;
public class CotizacionController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
       
        return View(new Persona());
    }
    [HttpPost]
    public IActionResult Index(Persona persona)
    {
        if (!ModelState.IsValid)
        {
            return View(persona);
        }
        return View("Resultado",persona);
    }
}
//Holaaaaaaaaaaaaaaa