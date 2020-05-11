using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Mark1",
                    Department = Dept.It,
                    Email = "mark@davetech.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Diwash",
                    Department = Dept.It,
                    Email = "diwash@davetech.com"
                },
                new Employee
                {
                    Id = 3,
                    Name = "Markintost",
                    Department = Dept.It,
                    Email = "kintost@davetech.com"
                }
                );

        }
    }
}
