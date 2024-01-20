using SınavProjectTask.Data;
using SınavProjectTask.Models;
using SınavProjectTask.Repositories.Interfaces;

namespace SınavProjectTask.Repositories;

public class QuestionCategoryRepository : GenericRepository<QuestionCategory>, IQuestionCategoryRepository
{
    public QuestionCategoryRepository(ApplicationDbContext context) : base(context)
    {
    }
}
