using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using Entities.Models;
using Services.Contracts;

namespace StoreApp.Controllers
{
    public class CategoryController: Controller
    {
        private readonly IServiceManager _manager;

        public CategoryController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index ()
        {
            var model = _manager.CategoryService.GetAllCategories(false);
            return View(model);
        }
    }
}