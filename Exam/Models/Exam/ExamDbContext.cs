using Microsoft.EntityFrameworkCore;

namespace Exam.Models.Exam
{
    public class ExamDbContext :DbContext
    {
        public ExamDbContext(DbContextOptions<ExamDbContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public  DbSet<Department> Departments { get; set; }

        public  DbSet<Employee> Employees { get; set; }
    }
}
