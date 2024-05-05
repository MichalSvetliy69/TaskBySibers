using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using TaskBySibers.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace TaskBySibers.Data.Context
{
    public class MSSQLContext : DbContext
    {
        public MSSQLContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectEmployee>()
                .HasKey(bc => new { bc.ProjectId, bc.EmployeeId });

            // Настроим удаление без каскада для связи с проектом
            modelBuilder.Entity<ProjectEmployee>()
                .HasOne(bc => bc.Project)
                .WithMany(b => b.ProjectEmployees)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(ep => ep.ProjectId);

            // Настроим удаление без каскада для связи с сотрудником
            modelBuilder.Entity<ProjectEmployee>()
                .HasOne(bc => bc.Employee)
                .WithMany(c => c.ProjectEmployees)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(ep => ep.EmployeeId);
        }




        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ProjectEmployee> ProjectEmployees { get; set; }    

    }
}
