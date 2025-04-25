using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace api;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Course, CourseDto>();
        CreateMap<User, UserDto>();
        CreateMap<Lesson, LessonDto>();
        CreateMap<Module, ModuleDto>();
        CreateMap<Progress, ProgressDto>();
        CreateMap<Review, ReviewDto>();
        
    }
}