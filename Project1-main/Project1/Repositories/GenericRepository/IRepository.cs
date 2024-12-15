using Project1.Repositories.StudentRepo;
using Project1.Repositories.UnitOfWorks;

namespace Project1.Repositories.GenericRepository;

public interface IRepository<T> : IUnitOfWork where T : class
{
    Task AddAsync(T entity);
    Task<T> GetByIdAsync(int id);
}
