using Microsoft.EntityFrameworkCore;
using SınavProjectTask.Models;

namespace SınavProjectTask.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<QuestionCategory> QuestionCategories { get; set; }
    }
}
