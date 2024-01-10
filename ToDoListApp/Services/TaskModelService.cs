using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
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

        public void Add(TaskModel task)
        {
            _context.Add(task);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var task = _context.TaskModels.FirstOrDefault(x => x.Id == id);
            _context.TaskModels.Remove(task);
            _context.SaveChanges();
        }

        public List<TaskModel> GetAllTask()
        {
            var tasks = _context.TaskModels.ToList();
            return tasks;
        }

        public void UpdateTask(TaskModel task)
        {
            var existingTask = _context.TaskModels.FirstOrDefault(t => t.Id == task.Id);
            if (existingTask != null)
            {
                existingTask.TaskName = task.TaskName;
                existingTask.IsComplete = task.IsComplete;
                _context.SaveChanges();
            }
        }
    }
}
