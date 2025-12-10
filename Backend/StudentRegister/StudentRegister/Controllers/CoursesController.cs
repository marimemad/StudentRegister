using BL.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using StudentRegister.Bases;

namespace StudentRegister.Controllers
{
    [ApiController]
    public class CoursesController : AppControllerBase
    {
        private readonly IUnitOfWorkManager _manager;

        public CoursesController(IUnitOfWorkManager manager)
        {
            _manager = manager;
        }
        //get all courses
        [HttpGet(Router.CourseRouting.List)]
        public async Task<IActionResult> GetCourses()
        {
            var response = await _manager.CourseManager.GetCoursesAsync();
            return NewResult(response);
        }
    }
}
