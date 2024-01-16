namespace SınavProjectTask.Models;

public class Category : BaseEntity
{
    public string CategoryName { get; set; }

    public virtual ICollection<Exam> Exams { get; set; }
}
