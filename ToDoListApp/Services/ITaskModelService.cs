using ToDoListApp.Data.Models;

namespace ToDoListApp.Services
{
    public interface ITaskModelService
    {
        List<TaskModel> GetAllTask();
        void Add(TaskModel task);
        void UpdateTask(TaskModel task);
        void Delete(int id);
    }
}
