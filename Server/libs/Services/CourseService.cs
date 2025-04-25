using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Services;

internal sealed class CourseService : ICourseService
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;

    public CourseService(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }

    public IEnumerable<CourseDto> GetAllCourses(bool trackChanges)
    {
        try
        {
            var courses = _repositoryManager.Course.GetAllCourses(trackChanges);

            var coursesDto = _mapper.Map<IEnumerable<CourseDto>>(courses);
            return coursesDto;
        }
        catch (System.Exception ex)
        {
            // Console.WriteLine("Error while retriving courses");
            Console.WriteLine(ex.Message);
            throw;
        }
    }

}