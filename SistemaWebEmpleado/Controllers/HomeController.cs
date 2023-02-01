using System;
using Microsoft.AspNetCore.Mvc;

namespace SistemaWebEmpleado.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.Nombre = "Bienvenido al sistema de Empleados";
            return View("Index");
        }
    }
}
