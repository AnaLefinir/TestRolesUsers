using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Entities;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly TestDbContext _context;

        public HomeController(TestDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //User user = new User();
            //Rol rol = new Rol();

            //rol.Description = "SuperPuchun";
            //rol.Value = 666;
            //_context.Roles.Add(rol);

            //user.Name = "Ana Lef";
            //user.Legajo = "L002233";
            ////user.Roles = new List<Rol>();
            ////user.Roles.Add(rol);
            //_context.Users.Add(user);

            //_context.SaveChanges();

            //var rolId = _context.Roles.Single(p => p.Description == "SupePuchun").Id;
            
            //UserRol newUserRol = new UserRol();
            //newUserRol.IdRol = rolId;
            //newUserRol.IdUser = user.Id;
            //user.UserRol.Add(newUserRol);
            //rol.UserRol.Add(newUserRol);

            //_context.SaveChanges();

            //ViewBag["userId"] = user.Id;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
