using api_flyingcape_test.Models;

namespace api_flyingcape_test.Interfaces;

public interface ICourseRepository
{
    ICollection<Course> GetCourses(string keyword = "", int typeId = 0);
}