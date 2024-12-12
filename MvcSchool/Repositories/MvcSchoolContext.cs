using Microsoft.EntityFrameworkCore;
using MvcSchool.Models;

namespace MvcSchool.Repositories
{
    public class MvcSchoolContext: DbContext
    {
        public MvcSchoolContext(DbContextOptions<MvcSchoolContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
