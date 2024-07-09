using ecomm.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ecomm.Controllers
{
    public class CategoryController : Controller
    {
        private readonly EcommContext _context;

        public CategoryController()
        {
            _context = new EcommContext();
        }
        [HttpGet]
        public IActionResult Index()
        {
            var data =  _context.Categories.ToList();
            return View(data);
        }
    }
}
