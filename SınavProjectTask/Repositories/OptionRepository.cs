using Microsoft.EntityFrameworkCore;
using SınavProjectTask.Data;
using SınavProjectTask.Models;
using SınavProjectTask.Repositories.Interfaces;

namespace SınavProjectTask.Repositories
{
    public class OptionRepository : GenericRepository<Option>, IOptionRepository 
    {
        public OptionRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
