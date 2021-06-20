using Microsoft.AspNetCore.Mvc;

namespace Weather.HTTP.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
