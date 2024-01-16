using SınavProjectTask.Enums;

namespace SınavProjectTask.Models;

public class Option
{
    public Guid Id { get; set; }
    public string OptionText { get; set; }
    public Guid QuestionId { get; set; }
    public virtual Question Question { get; set; }
}
