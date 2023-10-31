using Application.DaoInterfaces;
using Domain;

namespace FileData.DAOs;

public class UserFileDao : IStudentDao, ITeacherDao
{
    private readonly FileContext context;

    public UserFileDao(FileContext context)
    {
        this.context = context;
    }
    

    public Task<Student?> GetByIdAsync(string userName)
    {
        Student? existing = context.Students.FirstOrDefault(u =>
            u.Id.Equals(userName, StringComparison.OrdinalIgnoreCase)
        );
        return Task.FromResult(existing);
    }

    public Task<Teacher> CreateAsyncTeacher(Teacher teacher)
    {
        int userId =1;
        if (context.Teachers.Any())
        {
            userId = context.Teachers.Max(s => s.UserId);
            userId++;
        }

        teacher.UserId = userId;

        context.Teachers.Add(teacher);
        context.SaveChanges();

        return Task.FromResult(teacher);
    }

    public Task<Student> CreateAsyncStudent(Student student)
    {
        int userId =1;
        if (context.Students.Any())
        {
            userId = context.Students.Max(s => s.UserId);
            userId++;
        }

        student.UserId = userId;

        context.Students.Add(student);
        context.SaveChanges();

        return Task.FromResult(student);
    }

    public Task<Teacher?> GetByIdAsyncTeacher(string id)
    {
        Teacher? existing = context.Teachers.FirstOrDefault(u =>
            u.Id.Equals(id, StringComparison.OrdinalIgnoreCase)
        );
        return Task.FromResult(existing);
    }
}