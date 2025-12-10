using AutoMapper;
using BL.Bases;
using BL.DTOs.Course;
using DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace BL.Managers.CourseManager
{
    public class CourseManager : ResponseHandler, ICourseManager
    {
        private readonly IUnitOfWorkRepo _repo;
        public IMapper _mapper { get; }

        public CourseManager(IUnitOfWorkRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        //get all courses
        public async Task<Response<List<CouseRead>>> GetCoursesAsync()
        {
            try
            {
                var courses = await _repo.CourseRepo.GetTableNoTracking().ToListAsync();
                var cousesRead = _mapper.Map<List<CouseRead>>(courses);
                return Success(cousesRead);
            }
            catch (Exception ex)
            {
                return BadRequest<List<CouseRead>>(ex.Message);
            }
        }
    }
}
