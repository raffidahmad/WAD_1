using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    public class Contact : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
