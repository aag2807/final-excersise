using Final_Project.Entity;
using Final_Proyect.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Proyect.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;
        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            Usuario user = new Usuario();
            return View("Login", user);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Validate(Usuario model)
        {
            if (ModelState.IsValid) { 
               
            }
                return View();
        }
    }
}
