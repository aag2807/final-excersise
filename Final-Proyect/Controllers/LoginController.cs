using Final_Project.Entity;
using Final_Proyect.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

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
                HttpContext.Session.SetString("Session", JsonConvert.SerializeObject(model));
                //var priceDetails = HttpContext.Session.GetString("Session");
                return RedirectToAction("Index");
            } else
            {
                return View();
            }
                
        }
    }
}
