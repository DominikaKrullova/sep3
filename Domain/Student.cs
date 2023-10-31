namespace Domain;

public class Student : User
{
    public string Name { get; set; }
    public Student(string password, string id, string name) : base(password, id)
    {
        Name = name;
    }
    
}