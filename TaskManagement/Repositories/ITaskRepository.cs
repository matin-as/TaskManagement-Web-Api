using TaskManagement.Domain;

namespace TaskManagement.Repositories
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskEntity>> GetAllTasksAsync();
        Task<TaskEntity> GetTaskByIdAsync(int id);
        Task<TaskEntity> AddTaskAsync(TaskEntity task);
        Task<TaskEntity> UpdateTaskAsync(TaskEntity task);
        Task<bool> DeleteTaskAsync(int id);
    }
}
