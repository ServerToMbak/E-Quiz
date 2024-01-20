using System.ComponentModel.DataAnnotations;

namespace SınavProjectTask.ViewModels;

public class CreateQuestionCategoryViewModel
{
    [Required]
    public string Name { get; set; }
}
