using Microsoft.EntityFrameworkCore;
using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {

        }
        public DbSet<EmployeeModel> Employees { get; set; }
        public DbSet<CompanyModel> Componies { get; set; }

    }
}
