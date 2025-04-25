using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Services;

internal sealed class LessonService : ILessonService
{
    private IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;

    public LessonService(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }

    public IEnumerable<LessonDto> GetAllLessons(bool trackChanges)
    {
        var lessons = _repositoryManager.Lesson.GetAllLessons(trackChanges);
        var lessonDto = _mapper.Map<IEnumerable<LessonDto>>(lessons);
        return lessonDto;
    }
}
