using Domain;

namespace Application.DaoInterfaces;

public interface IStudentDao
{
    Task<Student?> GetByIdAsync(string id);
    Task<Student> CreateAsyncStudent(Student student);

}