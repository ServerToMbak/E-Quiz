namespace SınavProjectTask.Models;

public class Option : BaseEntity
{
    public string OptionText { get; set; }


    public Guid QuestionId { get; set; }
    public virtual Question Question { get; set; }
}
