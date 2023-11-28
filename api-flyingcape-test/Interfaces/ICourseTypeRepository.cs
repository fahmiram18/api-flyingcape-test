using api_flyingcape_test.Models;

namespace api_flyingcape_test.Interfaces;

public interface ICourseTypeRepository
{
    ICollection<CourseType> GetCourseTypes();
}