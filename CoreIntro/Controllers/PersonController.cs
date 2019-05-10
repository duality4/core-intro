using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreIntro.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreIntro.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var model = new Person("Kalle", 10000);

            return View(model);
        }
    }
}