using EmployeMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeMVC.Data
{
    public class DatabaseDbContext :DbContext
    {
        //DbContextOptions carries configuration information such as the connection , database provider
        public DatabaseDbContext(DbContextOptions<DatabaseDbContext> options): base(options) 
        {
            
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee {
                    Id=1,
                    Name= "Prajwol Basnet",
                    Email="prajal.basnet0@gmail.com",
                    PhoneNo="9861329908",
                    Address="Bhaktapur",
                    DepartmentId= 1,
                    DesignationId = 1
                }
                );
            modelBuilder.Entity<Department>().HasData(
                new Department {
                    Id=1,
                    Name="IT Department"
                }
                );
            modelBuilder.Entity<Designation>().HasData(
              new Designation
              {
                  Id = 1,
                  Name = "Intern"
              }
               
              );
        }
    }
}
