
using Shared.DataTransferObjects;

namespace Service.Contracts;

public interface ILessonService
{
    public IEnumerable<LessonDto> GetAllLessons(bool trackChanges);

}

