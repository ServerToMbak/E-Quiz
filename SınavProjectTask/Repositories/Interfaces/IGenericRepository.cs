using SınavProjectTask.Models;

namespace SınavProjectTask.Repositories.Interfaces;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<int> Add(T entity);
    Task<int> Delete(Guid id);
    Task<int> Delete(T entity);
    Task<int> Update(T entity);
    Task<T> GetById(int id);
    Task<List<T>> GetAll();
    
}
