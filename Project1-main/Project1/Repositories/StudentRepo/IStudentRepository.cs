using Microsoft.EntityFrameworkCore;

namespace Project1.Repositories.StudentRepo;
using Project1.Repositories.GenericRepository;
using Project1.Model;




public interface IStudentRepository : IRepository<Student>
{
    
}