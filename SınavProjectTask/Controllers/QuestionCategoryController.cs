using Microsoft.AspNetCore.Mvc;
using SınavProjectTask.Models;
using SınavProjectTask.Repositories.Interfaces;
using SınavProjectTask.ViewModels;

namespace SınavProjectTask.Controllers
{
    public class QuestionCategoryController : Controller
    {
        private readonly IQuestionCategoryRepository _questionCategory;

        public QuestionCategoryController(IQuestionCategoryRepository questionCategory)
        {
            _questionCategory = questionCategory;
        }

        public async Task<IActionResult> Index()
        {
            var list =await _questionCategory.GetAll();

            var questionCategories = list.Select(p => new CreateQuestionCategoryViewModel
            {
                Name = p.QuestionCategoryName,
            }).ToList();

            var res = new IndexQuestionCategoryViewModel();

            res.QuestionCategories = questionCategories;
            res.Count = questionCategories.Count();

            return View(res);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var CQVM = new CreateQuestionCategoryViewModel();

            return View(CQVM);  
        }



        [HttpPost]
        public async Task<IActionResult> Create(CreateQuestionCategoryViewModel CQVM)
        {
            
            if(!ModelState.IsValid)
            {
                return View("Create");
            }

            var questiınCategory = new QuestionCategory
            {
                QuestionCategoryName = CQVM.Name,
            };


            await _questionCategory.Add(questiınCategory);

            return RedirectToAction("Index");
        }
    }
}
