using SınavProjectTask.Data;
using SınavProjectTask.Models;
using SınavProjectTask.Repositories.Interfaces;

namespace SınavProjectTask.Repositories;

public class CategoryRepository :  GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(ApplicationDbContext context) : base(context)
    {
    }
}
