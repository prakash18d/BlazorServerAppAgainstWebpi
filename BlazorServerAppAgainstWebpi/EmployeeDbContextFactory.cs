using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerAppAgainstWebpi
{
    public class EmployeeDbContextFactory:IDesignTimeDbContextFactory<EmployeeDbContext>
    {
        public EmployeeDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EmployeeDbContext>();
            var connStr = ConfigurationHelper.GetCurrentSettings("ConnectionStrings:DefaultConnection");
            optionsBuilder.UseSqlServer(connStr);
            return new EmployeeDbContext(optionsBuilder.Options);
        }
    }
}
