namespace Domain.DTOs;

public class UserCreationDto
{
    public string Id { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    
    public UserCreationDto(string id, string password, string name)
    {
        Id = id;
        Password = password;
        Name = name;
    }
}