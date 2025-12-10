using AutoMapper;
using BL.DTOs.Course;
using BL.DTOs.Student;
using DAL.Models;

namespace BL.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, StudentRead>();
            CreateMap<Course, CouseRead>();
            CreateMap<StudentWrite, Student>();
        }

    }
}
