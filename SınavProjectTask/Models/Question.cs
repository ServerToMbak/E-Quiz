using SınavProjectTask.Enums;

namespace SınavProjectTask.Models
{
    public class Question : BaseEntity
    {
        public string QuestionContent { get; set; }


        public virtual ICollection<Exam> Exam { get; set; }


        public OptionType OptionType { get; set; }

        public Guid QuestionCategoryId { get; set; }
        public virtual QuestionCategory QuestionCategory { get; set; }


        public Guid CorrectOptionId { get; set; }
        public virtual ICollection<Option> Options { get; set; }
    }
}
