using Microsoft.EntityFrameworkCore;
using WebApplication2.DALLayer.Models;

namespace WebApplication2.DALLayer
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) {
            Database.EnsureCreated();
        }
        public DbSet<UserAnswers> UserAnswersTable { get; set; }
    }
}
