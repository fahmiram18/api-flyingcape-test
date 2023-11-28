namespace api_flyingcape_test.Models;

public class Course
{
    public int Id { get; set; }

    public string Name { get; set; }

    public CourseType CourseType { get; set; }
}