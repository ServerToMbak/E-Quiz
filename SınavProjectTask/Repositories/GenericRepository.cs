using Microsoft.EntityFrameworkCore;
using SınavProjectTask.Models;
using SınavProjectTask.Repositories.Interfaces;

namespace SınavProjectTask.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private readonly DbContext _context;
    protected DbSet<T> entity => _context.Set<T>();
    public GenericRepository(DbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public virtual async Task<int> Add(T entity)
    {
        await this.entity.AddAsync(entity);
        return await _context.SaveChangesAsync();
    }

    public virtual async Task<int> Delete(Guid id)
    {
        var entity = await this.entity.FindAsync(id);
        
        return await Delete(entity);
    }

    public virtual Task<int> Delete(T entity)
    {
        if(_context.Entry(entity).State == EntityState.Detached)
        {
            this.entity.Attach(entity);
        }
        this.entity.Remove(entity);

        return _context.SaveChangesAsync();
    }

    public virtual async Task<List<T>> GetAll()
    {
       return await this.entity.ToListAsync();
    }

    public virtual async Task<T> GetById(int id)
    {
        return await this.entity.FindAsync(id);
    }

    public virtual async Task<int> Update(T entity)
    {
        this.entity.Entry(entity).State = EntityState.Modified;
        return await _context.SaveChangesAsync();
    }
}
