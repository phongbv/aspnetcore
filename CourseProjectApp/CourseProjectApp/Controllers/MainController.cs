using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CourseProjectApp.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.value = "My first MVC Route!!!!!";
            return View();
        }
    }
}