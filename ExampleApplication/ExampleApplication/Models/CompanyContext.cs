using Microsoft.EntityFrameworkCore;

namespace ExampleApplication.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext()
        {

        }
        public CompanyContext(DbContextOptions options):base(options)
        {

        }
        public virtual DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee() { Id = 101, Name = "Ramu", Salary = 123456.7f });
        }
    }
}
