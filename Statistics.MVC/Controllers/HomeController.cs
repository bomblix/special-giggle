using Microsoft.AspNetCore.Mvc;

namespace Statistics.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Core.Hello().Hello;
            return View((object)model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
