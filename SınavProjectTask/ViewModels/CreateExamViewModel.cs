using SınavProjectTask.Models;
using System.ComponentModel.DataAnnotations;

namespace SınavProjectTask.ViewModels;

public class CreateExamViewModel
{
    [Required]
    [MinLength(2)]
    public string ExamName { get; set; }
    [Required]
    public string Description { get; set; }
    public int MaximumTime { get; set; }
    [Required(ErrorMessage ="The category field is required")]
    public Guid CategoryId { get; set; }
    [Required]
    public int SuccessPoint { get; set; }
    public  List<Category>? Categories { get; set; } 
}
