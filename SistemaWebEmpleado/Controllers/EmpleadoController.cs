using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaWebEmpleado.Data;
using SistemaWebEmpleado.Models;

namespace SistemaWebEmpleado.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly DBEmpleado context;
        public EmpleadoController(DBEmpleado context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var medico = context.Empleados.ToList();
            return View(medico);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Empleado empleado = new Empleado();

            return View("Register", empleado);
        }

        //post: Opera/Create
        [HttpPost]
        public ActionResult Create(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                context.Empleados.Add(empleado);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleado);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Empleado empleado = TraerUna(id);
            if (empleado == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", empleado);
            }
        }

        private Empleado TraerUna(int id)
        {
            return context.Empleados.Find(id);
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            var empleado = TraerUna(id);
            if (empleado == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", empleado);
            }

        }

        [ActionName("Delete")]
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            Empleado empleado = TraerUna(id);
            if (empleado == null)
            {
                return NotFound();
            }
            else
            {
                context.Empleados.Remove(empleado);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var empleado = context.Empleados.Find(id);
            if (empleado == null)
            {
                return NotFound();
            }
            else
            {
                return View("Edit", empleado);
            }
        }


        [ActionName("Edit")]
        [HttpPost]
        public ActionResult EditConfirmed(Empleado empleado)
        {

            context.Entry(empleado).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}


