using Microsoft.EntityFrameworkCore;

namespace Day2.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MAHMO;Database=TEST;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Dependant> Dependants { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Works_For> Works_For {  get; set; }
    }
}
