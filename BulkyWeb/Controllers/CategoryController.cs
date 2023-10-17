using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        public ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            
            _db = db;
            Console.WriteLine("Any String " + db);
            var x = 0;
        }
        public IActionResult Index(ApplicationDbContext db)
        {
            var x = 1;
            List<Category> objCategoryList = _db.Categories.ToList();
            return View();
        }
    }
}
