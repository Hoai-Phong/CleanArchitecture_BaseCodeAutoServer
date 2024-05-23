using BaseCodeAutoSever.Domain.Entities;

namespace BaseCodeAutoSever.Application.Common.Services.Data;

public interface IApplicationDbContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : class;
    
    DbSet<TodoList> TodoLists { get; }
    
    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
