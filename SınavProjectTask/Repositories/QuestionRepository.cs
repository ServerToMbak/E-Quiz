using Microsoft.EntityFrameworkCore;
using SınavProjectTask.Data;
using SınavProjectTask.Models;
using SınavProjectTask.Repositories.Interfaces;

namespace SınavProjectTask.Repositories
{
    public class QuestionRepository : GenericRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
