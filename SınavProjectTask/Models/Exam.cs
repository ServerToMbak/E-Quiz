namespace SınavProjectTask.Models;

public class Exam : BaseEntity
{
    public string ExamName { get; set; }
    public string Description { get; set; }
    public int MaximumTime { get; set; } //it will be represented as minutes
    public int SuccessPoint { get; set; }  


    public Guid CategoryId { get; set; }
    public virtual Category Category { get; set; }



    public virtual ICollection<Question> Question { get; set; }

}
