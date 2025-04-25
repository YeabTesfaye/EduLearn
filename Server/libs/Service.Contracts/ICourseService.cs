

using Shared.DataTransferObjects;

namespace Service.Contracts;

public interface ICourseService
{
    public IEnumerable<CourseDto> GetAllCourses(bool trackChanges);
}

