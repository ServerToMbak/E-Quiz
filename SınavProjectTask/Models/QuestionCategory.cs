namespace SınavProjectTask.Models
{
    public class QuestionCategory
    {
        public Guid Id { get; set; }
        public string QuestionCategoryName { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
