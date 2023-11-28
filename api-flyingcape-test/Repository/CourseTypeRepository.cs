using api_flyingcape_test.Data;
using api_flyingcape_test.Interfaces;
using api_flyingcape_test.Models;

namespace api_flyingcape_test.Repository;

public class CourseTypeRepository : ICourseTypeRepository
{
    private DataContext _context;
    
    public CourseTypeRepository(DataContext context)
    {
        _context = context;
    }


    public ICollection<CourseType> GetCourseTypes()
    {
        return _context.CourseTypes.ToList();
    }
}