using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBRepository;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebAPPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContext _context;
          
        public HomeController(MyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.User.ToList();
            return View(model);
        }
    }
}