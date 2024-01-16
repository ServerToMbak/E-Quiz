using Microsoft.AspNetCore.Mvc;
using SınavProjectTask.Repositories.Interfaces;

namespace SınavProjectTask.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
