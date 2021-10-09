using Final_Project.Entity;
using Final_Proyect.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace Final_Proyect.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;
       
        public string lblMessage { get; set; }
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
        public  IActionResult Validate(Usuario model)
        {
            if (ModelState.IsValid) {
                var user = new Usuario();
                user = _context.Usuarios.SingleOrDefault(x => (x.Email == model.Email) && (x.Password == model.Password));
                if (user != null)
                {
                    HttpContext.Session.SetString("Session", JsonConvert.SerializeObject(user));
                    return RedirectToAction("Index","Home");
                } else
                {
                    ModelState.AddModelError(nameof(Usuario.Password), "Email or Password not found or matched");
                    return View(model);
                }
            } else
            {
                ModelState.AddModelError(nameof(Usuario), "Error en el modelo");
                return View(model);
            }
                
        }
    }
}
