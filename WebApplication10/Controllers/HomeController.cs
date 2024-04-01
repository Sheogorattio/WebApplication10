using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class User
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            User user = new()
            {
                Name = "John Doe",
                Email = "john.doe@example.com"
            };

            ViewBag.UserName = user.Name;
            ViewBag.UserEmail = user.Email;

            ViewData["UserName"] = user.Name;
            ViewData["UserEmail"] = user.Email;

            return View(user);
        }
    }


}
