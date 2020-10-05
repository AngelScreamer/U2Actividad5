using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Unidad2Actividad5.Models;
namespace Unidad2Actividad5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            animalesContext context = new animalesContext();
            AnimalesViewModel vm = new AnimalesViewModel();
            vm.Clase = context.Clase.OrderBy(x => x.Nombre.ToUpper());
            Random r = new Random();
            vm.Imagen = r.Next(1, 6);
            return View(vm);
        }
        [Route("{id}")]
        public IActionResult Clases(string id)
        {
            var nombre = id.Replace("-", " ").ToLower();
            animalesContext context = new animalesContext();
            var categ = context.Clase.Include(x => x.Especies).ThenInclude(x=>x.IdClaseNavigation).OrderBy(x => x.Nombre).FirstOrDefault(x => x.Nombre.ToLower() == nombre);
            if (categ == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(categ);
            }
        }
    }
}
