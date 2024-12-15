using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Repositories.UnitOfWorks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project1.Repositories.GenericRepository;

public class Repository<T> : UnitOfWork, IRepository<T> where T : class
{
    #region Ctor & Properties
    
    private readonly DbSet<T> _dbSet;

    public Repository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _dbSet = dbContext.Set<T>();
    }
    
    #endregion
    
    #region Implementation

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity).ConfigureAwait(false);
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id).ConfigureAwait(false);
    }
    
    #endregion
    
}