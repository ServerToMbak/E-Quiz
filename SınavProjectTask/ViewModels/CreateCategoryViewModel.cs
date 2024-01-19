using System.ComponentModel.DataAnnotations;

namespace SınavProjectTask.ViewModels;

public class CreateCategoryViewModel
{
    public Guid CategoryId { get; set; }
    [Required]
    public string CategoryName { get; set; }
}
