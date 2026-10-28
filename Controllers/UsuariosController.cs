using Microsoft.AspNetCore.Mvc;

namespace inventariosmvc.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Seguridad()
        {
            return View();
        }
    }
}