using SweeftApiDomain;
using SweeftApiDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftApiAbstractions.Services
{
    public class TeachersService :ITeachersService
    {
        private readonly DBContext _context;

        public TeachersService(DBContext context)
        {
            _context = context;
        }

        public List<Teacher> GetAllTeachersByStudent(string studentName)
        {
   
            var teachers = _context.PupilTeachers
                .Where(pt => pt.Pupil.Name == studentName)
                .Select(pt => pt.Teacher)
                .ToList();

            return teachers;
        }
    }
}
