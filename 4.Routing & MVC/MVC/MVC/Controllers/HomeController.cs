using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult GetView(ProfileData profileData)
        {
            return View("~/Views/Index.html", profileData);
        }
    }
}
