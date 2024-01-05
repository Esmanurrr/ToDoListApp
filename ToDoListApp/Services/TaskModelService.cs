using Microsoft.EntityFrameworkCore;
using ToDoListApp.Data;
using ToDoListApp.Data.Models;

namespace ToDoListApp.Services
{
    public class TaskModelService : ITaskModelService
    {
        private readonly IDbContextFactory<AppDbContext> _context;

        public TaskModelService(IDbContextFactory<AppDbContext> context)
        {
            _context = context;
        }

        public void AddTask(TaskModel task)
        {

        }
    }
}
