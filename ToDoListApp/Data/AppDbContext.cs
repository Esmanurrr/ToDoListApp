using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ToDoListApp.Data.Models;

namespace ToDoListApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TaskModel> TaskModels { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
