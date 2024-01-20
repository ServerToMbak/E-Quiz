using SınavProjectTask.Enums;

namespace SınavProjectTask.ViewModels;

public class CreateQuestionViewModel
{
    public string QuestionContent { get; set; }
    public OptionType OptionType { get; set; }

    public Guid QuestionCategoryId { get; set; }


    public Guid ExamId { get; set; }    
    public Guid CorrectOptionId { get; set; }
    public CreateOptionViewModel Option { get; set; }
}
