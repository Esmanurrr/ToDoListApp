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

        public void Add(TaskModel task)
        {
             _context.Add(task);
            _context.SaveChanges();

        }

        public List<TaskModel> GetAllTask()
        {
            var tasks = _context.TaskModels.ToList();
            return tasks;
        }

        public void Update(int id,string title)
        {
            var task = _context.TaskModels.FirstOrDefault(x => x.Id == id);
            task.TaskName = title;
            _context.TaskModels.Update(task);
            _context.SaveChanges();

        }
    }
}
