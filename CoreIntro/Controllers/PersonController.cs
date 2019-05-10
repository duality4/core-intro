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
        public IActionResult Index(string Name, int Salary)
        {
            var model = new Person(Name, Salary);

            return View(model);
        }
        public IActionResult AllPersons(string Name, int Salary)
        {
            var model = new List<Person>
            {
                new Person("Kalle", 10000),
                new Person("Lisa", 1000)
            };
            
            return View(model);
        }
    }
}