using Microsoft.AspNetCore.Mvc;

namespace VendasMVC.Controllers
{
    public class VendedoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
