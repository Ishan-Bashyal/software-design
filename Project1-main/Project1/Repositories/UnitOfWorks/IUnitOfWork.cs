namespace Project1.Repositories.UnitOfWorks;

public interface IUnitOfWork : IDisposable
{
    void Commit();
    Task CommitAsync();
}