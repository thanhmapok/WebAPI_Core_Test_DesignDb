using Microsoft.AspNetCore.Mvc;

namespace WebAPI_Core_Test_DesignDb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
