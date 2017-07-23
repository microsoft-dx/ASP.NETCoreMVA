using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class HomeController
    {
        [HttpGet("/")]
        public string Index() => "Hello from MVC!";
    }
}
