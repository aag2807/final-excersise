using System;
using Final_Project.Entity;
using Final_Proyect.Data;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Final_Proyect.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Final_Proyect.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TransactionController( ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            var transactions = this._context.HistoricoTransferencias.ToList();

            var transactionList = new List<Final_Project.Entity.HistoricoTransferencia>();

            foreach (var item in transactions)
            {
                transactionList.Add(item);
            }

            ViewData["T"] = transactionList;

            return View();
        }


    }
}
