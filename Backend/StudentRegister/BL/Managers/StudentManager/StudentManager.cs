using AutoMapper;
using BL.Bases;
using BL.DTOs.Student;
using DAL.Models;
using DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace BL.Managers.StudentManager
{
    class StudentManager : ResponseHandler, IStudentManager
    {
        private readonly IUnitOfWorkRepo _repo;
        public IMapper _mapper { get; }

        public StudentManager(IUnitOfWorkRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Response<List<StudentRead>>> GetStudentWithCoursesAsync()
        {
            try
            {
                var students = await _repo.StudentRepo.GetStudentWithCoursesAsync();
                var studentsRead = _mapper.Map<List<StudentRead>>(students);
                return Success(studentsRead);
            }
            catch (Exception ex)
            {
                return BadRequest<List<StudentRead>>(ex.Message);
            }

        }

        public async Task<Response<string>> CreateStudentAsync(StudentWrite model)
        {
            if (model.CourseIds.Count < 1 || model.CourseIds.Count > 2)
                return BadRequest<string>(" minimum 1 and maximum 2 courses");
            try
            {
                var student = _mapper.Map<Student>(model);
                student.Id = Guid.NewGuid().ToString();
                var courses = await _repo.CourseRepo.GetTableAsTracking().Where(c => model.CourseIds.Contains(c.Id)).ToListAsync();
                student.Courses = courses;
                var result = await _repo.StudentRepo.AddAsync(student);
                return Success("Created Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest<string>(ex.Message);
            }
        }
    }
}
