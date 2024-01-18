using Microsoft.AspNetCore.Mvc;
using SınavProjectTask.Repositories.Interfaces;

namespace SınavProjectTask.Controllers
{
    public class ExamController : Controller
    {
        private readonly IExamRepository _examRepository;

        public ExamController(IExamRepository examRepository)
        {
            _examRepository = examRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create() 
        {

            return View();
        }
    }
}
