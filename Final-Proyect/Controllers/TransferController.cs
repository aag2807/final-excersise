using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Entity;
using Final_Proyect.Data;
using Final_Proyect.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Final_Proyect.Controllers
{
    public class TransferController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TransferController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            ViewData["error"] = false;
            return View();
        }

        [HttpPost]
        public IActionResult Index(DynamicTransferModel transfer)
        {
            Cuenta accountRef;
            Usuario userRef;
            try
            {
                accountRef =
                    _context
                        .Cuentas
                        .SingleOrDefault(x =>
                            x.No_Cuenta == transfer.No_CuentaReceptor);
                userRef =
                    _context
                        .Usuarios
                        .SingleOrDefault(x => x.Id == accountRef.Id_usuario);
            }
            catch
            {
                accountRef = null;
                userRef = null;
            }

            if (accountRef == null || userRef == null)
            {
                ViewData["error"] = true;
                return View();
            }

            var newItemToAdd = new HistoricoTransferencia();
            newItemToAdd.Id = transfer.Id;
            newItemToAdd.No_transferencia = (transfer.Id).ToString();
            newItemToAdd.Monto = transfer.Monto;
            newItemToAdd.Fecha = Convert.ToDateTime(transfer.Fecha);
            newItemToAdd.No_cuentaEmisor = transfer.No_cuentaEmisor;
            newItemToAdd.No_CuentaReceptor = transfer.No_CuentaReceptor;
            newItemToAdd.Id_Cuenta = accountRef.Id;
            newItemToAdd.Cuenta = accountRef;

            _context.Add<HistoricoTransferencia> (newItemToAdd);
            _context.SaveChanges();
            return View();
        }
    }
}
