using Microsoft.AspNetCore.Mvc;

namespace inventariosmvc.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}