using BL.DTOs.Student;
using BL.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using StudentRegister.Bases;

namespace StudentRegister.Controllers
{
    [ApiController]
    public class StudentsController : AppControllerBase
    {
        private readonly IUnitOfWorkManager _manager;

        public StudentsController(IUnitOfWorkManager manager)
        {
            _manager = manager;
        }

        //get all students
        [HttpGet(Router.StudentRouting.List)]
        public async Task<IActionResult> GetStudents()
        {
            var response = await _manager.StudentManager.GetStudentWithCoursesAsync();
            return NewResult(response);
        }

        //create student
        [HttpPost(Router.StudentRouting.Create)]
        public async Task<IActionResult> CreateStudent([FromBody] StudentWrite student)
        {
            var response = await _manager.StudentManager.CreateStudentAsync(student);
            return NewResult(response);
        }
    }
}
