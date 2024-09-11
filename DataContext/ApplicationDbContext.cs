using System;
using CrudApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudApi.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}