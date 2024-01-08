using Microsoft.EntityFrameworkCore;
using ToDoListApp.Data;
using ToDoListApp.Data.Models;

namespace ToDoListApp.Services
{
    public class TaskModelService : ITaskModelService
    {
        private readonly AppDbContext _context;

        public TaskModelService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TaskModel task)
        {
            await _context.AddAsync(task);
            _context.SaveChanges();

        }

        public List<TaskModel> GetAllTask()
        {
            var tasks = _context.TaskModels.ToList();
            return tasks;
        }
    }
}
