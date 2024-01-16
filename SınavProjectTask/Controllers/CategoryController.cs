using Microsoft.AspNetCore.Mvc;
using SınavProjectTask.Models;
using SınavProjectTask.Repositories.Interfaces;
using SınavProjectTask.ViewModels;

namespace SınavProjectTask.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data =await _categoryRepository.GetAll();
            var categories = new GetAllCategoriesViewModel
            {
                Categories = data,
            };
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var response = new CreateCategoryViewModel();
            return View(response);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryViewModel categoryVM)
        {
            if(ModelState.IsValid)
            {
                var category = new Category
                {
                    CategoryName = categoryVM.CategoryName
                };

                await _categoryRepository.Add(category);
            }
            else
            {
                ModelState.AddModelError("", "Adding Category has failed, try again");
            }
            return View(categoryVM);
        }
    }
}
