using Domain;
using Domain.DTOs;

namespace Application.LogicInterfaces;

public interface ITeacherLogic
{
    Task<Teacher> CreateAsyncTeacher(UserCreationDto userToCreate);

}