using SınavProjectTask.Models;

namespace SınavProjectTask.ViewModels;

public class CreateExanViewModel
{
    public string ExamName { get; set; }
    public string Description { get; set; }
    public int MaximumTime { get; set; }
    public Guid CategoryId { get; set; }
    public virtual List<Question> Question { get; set; }
}
