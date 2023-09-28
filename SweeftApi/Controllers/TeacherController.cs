using Microsoft.AspNetCore.Mvc;
using SweeftApiAbstractions.Services;

namespace SweeftApi.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeachersService _teachersService;

        public TeacherController(ITeachersService teachersService)
        {
            _teachersService = teachersService;
        }

        [HttpGet("{studentName}/teachers")]
        public IActionResult GetTeachersByStudent(string studentName)
        {
            var teachers = _teachersService.GetAllTeachersByStudent(studentName);

            if (teachers == null || !teachers.Any())
            {
                return NotFound($"No teachers found for student '{studentName}'.");
            }

            return Ok(teachers);
        }
    }
}
