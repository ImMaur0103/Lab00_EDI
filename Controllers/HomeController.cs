using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab0_EDI.Models;
using Lab0_EDI.Extra;

namespace Lab0_EDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index(String Nombre, String Apellido, String Telefono, String Descripcion)
        {
            if ((Nombre != "ingrese nombre" && Nombre != null) && (Apellido != "ingrese Apellido" && Apellido != null) &&
               (Telefono != "ingrese Telefono" && Telefono != null ) && (Descripcion != "ingrese Descripcion" && Descripcion != null))
            {
                Client Nuevo_Cliente = new Client();
                Nuevo_Cliente.Name = Nombre;
                Nuevo_Cliente.LastName = Apellido;
                Nuevo_Cliente.PhoneNumber = Telefono;
                Nuevo_Cliente.Description = Descripcion;
                ViewBag.Mensaje = "Guardado";
                Singleton.Instance.ClientsList.Add(Nuevo_Cliente); 
            }
            else
            {

            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View(Singleton.Instance.ClientsList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
