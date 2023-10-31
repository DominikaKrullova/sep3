using Application.LogicInterfaces;
using Domain;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class TeachersController : ControllerBase
{
    private readonly ITeacherLogic teacherLogic;

    public TeachersController(ITeacherLogic teacherLogic)
    {
        this.teacherLogic = teacherLogic;
    }
    
    [HttpPost]
    public async Task<ActionResult<Teacher>> CreateAsyncTeacher(UserCreationDto dto)
    {
        try
        {
            Teacher teacher = await teacherLogic.CreateAsyncTeacher(dto);
            return Created($"/teachers/{teacher.UserId}", teacher);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, e.Message);
        }
    }
    
}
