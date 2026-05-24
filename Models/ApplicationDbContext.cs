using Microsoft.EntityFrameworkCore;
using System;

namespace DotNetAsessment.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeNo = "00001", EmployeeName = "Alex Song", BirthDate = new DateTime(1979, 12, 31) },
                new Employee { EmployeeNo = "00002", EmployeeName = "Johnson Ong", BirthDate = new DateTime(1985, 1, 27) },
                new Employee { EmployeeNo = "00003", EmployeeName = "Henry Lim", BirthDate = new DateTime(1985, 12, 26) },
                new Employee { EmployeeNo = "00004", EmployeeName = "Anders Ngo", BirthDate = new DateTime(1986, 2, 05) },
                new Employee { EmployeeNo = "00005", EmployeeName = "Summer Leow", BirthDate = new DateTime(1980, 8, 12) }
            );
        }
    }
}