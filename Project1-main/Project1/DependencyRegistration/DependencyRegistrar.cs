using System.Xml.Serialization;
using Project1.Repositories.StudentRepo;
using Project1.Repositories.UnitOfWorks;
using Project1.Repositories.GenericRepository;


namespace Project1.DependencyRegistration;

public class DependencyRegistrar
{
    public static void Register(IServiceCollection services, IConfiguration configuration)
    {
        //Common
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        
        //Repository
        services.AddScoped(typeof(IStudentRepository), typeof(StudentRepository));
    }
}