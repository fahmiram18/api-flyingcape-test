using api_flyingcape_test.Data;
using api_flyingcape_test.Interfaces;
using api_flyingcape_test.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace api_flyingcape_test.Repository;

public class CourseRepository : ICourseRepository
{
    private DataContext _context;
    public CourseRepository(DataContext context)
    {
        _context = context;
    }
    
    public ICollection<Course> GetCourses(string keyword = "", int typeId = 0)
    {
        if (!keyword.IsNullOrEmpty() && typeId >= 0)
        { 
            return _context.Courses
                .Include(c => c.CourseType)
                .Where(c => c.Name.Contains(keyword) && c.CourseType.Id == typeId)
                .ToList();
        }
        else
        {
            return _context.Courses.Include(c => c.CourseType).ToList();
        }
    }
}