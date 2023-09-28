using SweeftApiDomain.Entities;

namespace SweeftApiAbstractions.Services
{
    public interface ITeachersService
    {
        List<Teacher> GetAllTeachersByStudent(string studentName);
    }
}