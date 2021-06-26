using Microsoft.EntityFrameworkCore;
using System;
using Employee;
namespace BlazorServerAppAgainstWebpi
{
    public class EmployeeDbContext:DbContext
    {
        
        public DbSet<EmployeeClass> Employees { get; set; }
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }
        //seedData
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<EmployeeClass>().HasData(
                new EmployeeClass
                {
                    EmployeeId = Guid.NewGuid().ToString(),
                    EmployeeFirstName = "Prakash",
                    EmployeeLastName = "Dubey",
                    pojectName = "Blazor"
                }); ;
        }
    }
}
