using DW.API.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DW.API.Services
{
    public interface ICourseService
    {
        Task<List<Student>> GetStudentsListByCourse(int courseId);
    }
}
