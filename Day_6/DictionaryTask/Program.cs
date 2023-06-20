
public class Teacher
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class TeacherService
{
    private Dictionary<Guid, Teacher> _teachers = new Dictionary<Guid, Teacher>();
    public void AddTeacher(Guid id, string firstName, string lastName)
    {
        var teacher = new Teacher { Id = id, FirstName = firstName, LastName = lastName };
        _teachers[id] = teacher;
    }
    public void ReplaceTeacher(Guid id, string firstName, string lastName)
    {
        if (_teachers.ContainsKey(id))
        {
            var teacher = new Teacher { Id = id, FirstName = firstName, LastName = lastName };
            _teachers[id] = teacher;
        }
    }
    public bool TryDeleteTeacher(Guid id)
    {
        return _teachers.Remove(id);
    }

    public List<Teacher> GetAllTeachers()
    {
        return _teachers.Values.ToList();
    }


}
 