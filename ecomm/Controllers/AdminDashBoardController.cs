using Microsoft.AspNetCore.Mvc;

namespace ecomm.Controllers
{
    public class AdminDashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
