using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ManagementOrderController : Controller
    {
        private readonly MYDataDBContext _context;
        public ManagementOrderController(MYDataDBContext context)
        {
            _context = context;
        }
        //[Authorize(Roles ="Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}