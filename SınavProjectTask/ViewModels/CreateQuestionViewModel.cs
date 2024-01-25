using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SınavProjectTask.Enums;
using SınavProjectTask.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SınavProjectTask.ViewModels;

public class CreateQuestionViewModel
{
    public Guid Id { get; set; }
    [Required]
    public string QuestionContent { get; set; }
    [Required]
    public OptionType OptionType { get; set; }
   
    public Guid QuestionCategoryId { get; set; }
    public Guid CorrectOptionId { get; set; } 
    public List<QuestionCategory>? QuestionCategories { get; set; }
}
