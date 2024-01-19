using SınavProjectTask.Models;

namespace SınavProjectTask.ViewModels;

public class ExamViewModel
{
    public string ExamName { get; set; }
    public string Description { get; set; }
    public int MaximumTime { get; set; } //it will be represented as minutes
    public int SuccessPoint { get; set; }

}
