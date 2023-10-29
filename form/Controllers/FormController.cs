using form.Models;
using Microsoft.AspNetCore.Mvc;

namespace form.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Form dane)
        {
            if (ModelState.IsValid)
            {
                return View("Result", dane);
            }
            else return View();

        }

        public IActionResult Wynik(Form dane)
        {

            return View(dane);
        }
    }
}
