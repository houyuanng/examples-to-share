using Microsoft.AspNetCore.Mvc;

namespace scratch1.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
