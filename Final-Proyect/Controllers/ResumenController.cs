using Final_Project.Entity;
using Final_Proyect.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Proyect.Controllers
{
    public class ResumenController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ResumenController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var obj = JsonConvert.DeserializeObject<Usuario>(HttpContext.Session.GetString("Session"));
            IEnumerable<Cuenta> Cuentas = new List<Cuenta>();
            ViewData["Sesion"] = true;
            ViewData["Nombre"] = obj.Name + " " + obj.Lastname;
            var userId = obj.Id;
            Cuentas = _context.Cuentas.Include(x => x.Usuario).ToList().Where(l => l.Id_usuario == userId);
            return View("Resumen",Cuentas);
        }
    }
}
