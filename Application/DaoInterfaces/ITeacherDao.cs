using Domain;

namespace Application.DaoInterfaces;

public interface ITeacherDao
{

    Task<Teacher> CreateAsyncTeacher(Teacher teacher);
    Task<Teacher?> GetByIdAsyncTeacher(string id);
}