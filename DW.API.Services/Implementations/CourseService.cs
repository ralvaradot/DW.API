using DW.API.Entity;
using DW.API.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DW.API.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly EnterpriseContext _context;

        public CourseService(EnterpriseContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetStudentsListByCourse(int courseId)
        {
            return await _context.Students
                .Where(s => s.CourseId == courseId).ToListAsync();
        }
    }
}
