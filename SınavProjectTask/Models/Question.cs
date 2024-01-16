using SınavProjectTask.Enums;

namespace SınavProjectTask.Models
{
    public class Question : BaseEntity
    {
        public string QuestionContent { get; set; }
        public Guid ExamId { get; set; }
        public OptionType OptionType { get; set; }
        public Guid CorrectOptionId { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual ICollection<Option> Options { get; set; }
    }
}
