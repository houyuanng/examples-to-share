using Microsoft.AspNetCore.Mvc;
using test_2.Models;

namespace test_2.Controllers
{
    [Route("api/cat")]
    public class CatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IEnumerable<Cat> GetAll()
        {
            var list = new List<Cat>();
            list.Add(new Cat() { Name = "Lilly" });
            list.Add(new Cat() { Name = "Lucy" });
            return list;
        }


        /*
        [HttpGet]
        public IEnumerable<Cat> GetAll()
        {
            var list = new List<Cat>();
            list.Add(new Cat() { Name = "Lilly" });
            list.Add(new Cat() { Name = "Lucy" });
            return list;
        }
        */
        [HttpGet("Hou Yuan")]
        public Cat Get(string name)
        {
            return new Cat() { Name = name };
        }
    }
}