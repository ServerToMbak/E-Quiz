namespace SınavProjectTask.ViewModels;

public class CreaetQuestionViewModel
{
    public string QuestionContent { get; set; }
    public Guid ExamId { get; set; }    
    public Guid CorrectOptionId { get; set; }
    public CreateOptionViewModel Option { get; set; }
}
