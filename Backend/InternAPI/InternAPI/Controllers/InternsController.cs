using Microsoft.AspNetCore.Mvc;

namespace InternAPI.Controllers
{
    public class InternsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
