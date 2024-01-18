using Microsoft.EntityFrameworkCore;
using SınavProjectTask.Data;
using SınavProjectTask.Models;
using SınavProjectTask.Repositories.Interfaces;

namespace SınavProjectTask.Repositories;

public class ExamRepository : GenericRepository<Exam>, IExamRepository
{
    public ExamRepository(ApplicationDbContext context) : base(context)
    {
    }
}
