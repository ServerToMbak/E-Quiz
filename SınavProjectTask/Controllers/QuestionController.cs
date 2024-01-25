using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SınavProjectTask.Models;
using SınavProjectTask.Repositories.Interfaces;
using SınavProjectTask.ViewModels;

namespace SınavProjectTask.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IOptionRepository _optionRepository;
        private readonly IQuestionCategoryRepository _questionCategoryRepository;

        public QuestionController(IQuestionRepository questionRepository, IOptionRepository optionRepository, IQuestionCategoryRepository questionCategoryRepository)
        {
            _questionRepository = questionRepository;
            _optionRepository = optionRepository;
            _questionCategoryRepository = questionCategoryRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var createQuestionVM = new CreateQuestionViewModel();
            createQuestionVM.QuestionCategories = await _questionCategoryRepository.GetAll();
    
            return View(createQuestionVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateQuestionViewModel CQVM)
        {
            CQVM.QuestionCategories = await _questionCategoryRepository.GetAll();

            if (!ModelState.IsValid)
            {
                    ModelState.AddModelError("CQVM.QuestionCategories","");       
                    return View(CQVM);
            }

            var question = new Question
            {
                CorrectOptionId = CQVM.CorrectOptionId,
                Id = CQVM.Id,
                OptionType = CQVM.OptionType,
                QuestionCategoryId = CQVM.QuestionCategoryId,
                QuestionContent = CQVM.QuestionContent,
            };

            await _questionRepository.Add(question);

            ViewBag.SuccessMessage = "Question created successfully Now add options to the question and the chose the correxct option";

            return View(CQVM);

        }


        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetQuestionById(Guid id)
        //{
        //    var question = await _questionRepository.GetById(id);

        //    return View(question);
        //}
    }
}
