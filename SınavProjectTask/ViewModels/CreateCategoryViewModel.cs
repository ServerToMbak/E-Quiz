using System.ComponentModel.DataAnnotations;

namespace SınavProjectTask.ViewModels;

public class CreateCategoryViewModel
{
    [Required]
    public string CategoryName { get; set; }
}
