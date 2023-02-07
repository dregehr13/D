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

        //get object for form
        [HttpGet]
        public IActionResult GradeCalcForm ()
        {
            return View();
        }

        //post object for form
        [HttpPost]
        public IActionResult GradeCalcForm(GradeCalcFormModel model)
        {
            return View();
        }
    }
}
