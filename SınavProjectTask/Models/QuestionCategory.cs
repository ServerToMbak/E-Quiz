namespace SınavProjectTask.Models;

public class QuestionCategory : BaseEntity
{
    public string QuestionCategoryName { get; set; }

    public ICollection<Question> Questions { get; set; }
}
