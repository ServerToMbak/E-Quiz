using Microsoft.AspNetCore.Mvc;
using SınavProjectTask.Models;
using SınavProjectTask.Repositories.Interfaces;
using SınavProjectTask.ViewModels;

namespace SınavProjectTask.Controllers
{
    public class OptionController : Controller
    {
        private readonly IOptionRepository _optionRepository;

        public OptionController(IOptionRepository optionRepository)
        {
            _optionRepository = optionRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateOptionViewModel optionViewModel)
        {
            
            if (!ModelState.IsValid)
            {
                return View(optionViewModel);
            }

            var option = new Option
            {
                OptionText = optionViewModel.OptionText,
                QuestionId = optionViewModel.QuestionId,
            };

            await _optionRepository.Add(option);

            // Clear the ModelState to allow for a clean form for the next option
            ModelState.Clear();

           
            ViewBag.SuccessMessage = "Option created successfully.";

            return RedirectToAction("Create", "QuestionController");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
