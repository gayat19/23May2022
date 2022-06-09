using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department() { Id = 1, Name = "Ops" },
                new Department() { Id = 2, Name="Fin"});
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 101, Name = "Ramu", Age = 21, DepartmentId = 1 },
                new Employee { Id = 102, Name = "Somu", Age = 35, DepartmentId = 1 },
                new Employee { Id = 103, Name = "Jimu", Age = 27, DepartmentId = 2 });
        }
    }
}
