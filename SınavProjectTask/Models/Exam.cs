namespace SınavProjectTask.Models;

public class Exam
{
    public Guid Id { get; set; }
    public string ExamName { get; set; }
    public string Description { get; set; }
    public TimeOnly ExamTime { get; set; } //it will be represented as minutes
    public Guid CategoryId { get; set; }
    
    public virtual Category Category { get; set; }
    public virtual ICollection<Question> Question { get; set; }

}
