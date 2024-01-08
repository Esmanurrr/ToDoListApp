using ToDoListApp.Data.Models;

namespace ToDoListApp.Services
{
    public interface ITaskModelService
    {
        List<TaskModel> GetAllTask();
        Task AddAsync(TaskModel task);
    }
}
