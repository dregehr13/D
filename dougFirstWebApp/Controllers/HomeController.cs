using Microsoft.AspNetCore.Mvc;
using MovieCollection.Models;

namespace MovieCollection.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //get object for form
        [HttpGet]
        public IActionResult MovieEntryForm()
        {
            return View();
        }

        //post object for form
        [HttpPost]
        public IActionResult MovieEntryForm(MovieEntry model)
        {
            return View();
        }
    }
}
