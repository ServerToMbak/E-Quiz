using Microsoft.AspNetCore.Mvc;
using SınavProjectTask.Models;
using SınavProjectTask.Repositories.Interfaces;
using SınavProjectTask.ViewModels;

namespace SınavProjectTask.Controllers
{
    public class ExamController : Controller
    {
        private readonly IExamRepository _examRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ExamController(IExamRepository examRepository, ICategoryRepository categoryRepository)
        {
            _examRepository = examRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<IActionResult> Index()
        {
            var examVM = new IndexExamViewModel();
            var data = await _examRepository.GetAll();
            if(data != null )
            {

                examVM.Exams = data.Select(p => new ExamViewModel()
                {
                    Description = p.Description,
                    ExamName = p.ExamName,
                    MaximumTime = p.MaximumTime,    
                    SuccessPoint = p.SuccessPoint
                }).ToList();

                examVM.Count = examVM.Exams.Count;
            }

            return View(examVM);

        }

        [HttpGet]
        public async Task<IActionResult> Create() 
        {
            var examVM = new CreateExamViewModel();
            examVM.Categories = await _categoryRepository.GetAll();
            return View(examVM);
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateExamViewModel examVM)
        {
            if(ModelState.IsValid)
            {
                var exam = new Exam
                {
                    ExamName = examVM.ExamName,
                    CategoryId = examVM.CategoryId,
                    Description = examVM.Description,
                    MaximumTime = examVM.MaximumTime,
                    SuccessPoint = examVM.SuccessPoint,
                    
                };

                await _examRepository.Add(exam);

                return RedirectToAction("Index");
            }
            else
            {
                examVM.Categories =await _categoryRepository.GetAll();
            }

            return View(examVM);
        }
    }
}
