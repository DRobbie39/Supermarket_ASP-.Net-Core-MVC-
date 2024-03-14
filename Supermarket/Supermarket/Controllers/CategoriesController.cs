using Microsoft.AspNetCore.Mvc;
using Supermarket.Models;

namespace Supermarket.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            //Hiển ra tất cả thể loại
            var categories = CategoriesRepository.GetCategories();
            //Kết hợp model vào view
            return View(categories);
        }

        public IActionResult Edit(int? id)
        {
            var category = CategoriesRepository.GetCategoryById(id.HasValue?id.Value:0);

            return View(category);
        }
    }
}
