using dougFirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dougFirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index ()
        {           
            return View();
        }

        [HttpGet]
        public IActionResult GradeCalcForm ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GradeCalcForm(GradeCalcFormModel model)
        {
            return View();
        }
    }
}
