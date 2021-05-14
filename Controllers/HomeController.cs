using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UserApp.Models;

namespace UserApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        private readonly string admin = Environment.GetEnvironmentVariable("admin");
        private readonly string user = Environment.GetEnvironmentVariable("user");

        DB_User objUser = new DB_User();
        public IActionResult Index()
        {
            if(TempData["idUser"]!=null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string email,string pass)
        {
            if(ModelState.IsValid)
            {
                var list = objUser.GetAllUsers();
                var data = list.Where(s => s.Email.Equals(email) && s.Pass.Equals(pass)).ToList();
                if(data.Count()>0)
                {
                    TempData["FullName"] = data.FirstOrDefault().firstname + " " + data.FirstOrDefault().lastname;
                    TempData["Email"] = data.FirstOrDefault().Email;
                    TempData["idUser"] = data.FirstOrDefault().Userid;
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Login Failed";
                    return RedirectToAction("Login");
                }

            }
            return View();
        }

        public ActionResult Logout()
        {
            TempData["FullName"] = null;
            TempData["Email"] = null;
            TempData["idUser"] = null;
            return RedirectToAction("Login");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
