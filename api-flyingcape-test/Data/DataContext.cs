using api_flyingcape_test.Models;
using Microsoft.EntityFrameworkCore;

namespace api_flyingcape_test.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public DbSet<CourseType> CourseTypes { get; set; }

    public DbSet<Course> Courses { get; set; }

    public DbSet<Partner> Partners { get; set; }
}