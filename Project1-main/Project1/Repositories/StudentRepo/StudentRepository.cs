using Project1.Data;
using Project1.Model;
using Project1.Repositories.GenericRepository;


namespace Project1.Repositories.StudentRepo;

public class StudentRepository : Repository<Student>, IStudentRepository
{
    public StudentRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        
    }
    
}