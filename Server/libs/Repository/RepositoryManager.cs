
using Contracts;

namespace Repository;

public class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;

    private readonly Lazy<ICourseRepository> _courseRepository;
    private readonly Lazy<ILessonRepository> _lessonRepository;
    private readonly Lazy<IModuleRepository> _moduleRepository;
    private readonly Lazy<IProgressRepository> _progressRepository;
    private readonly Lazy<IReviewRepository> _reviewRepository;
    private readonly Lazy<IUserRepository> _userRepository;

    public RepositoryManager(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;

        _courseRepository = new Lazy<ICourseRepository>(() => new CourseRepository(repositoryContext));
        _lessonRepository = new Lazy<ILessonRepository>(() => new LessonRepository(repositoryContext));
        _moduleRepository = new Lazy<IModuleRepository>(() => new ModuleRepository(repositoryContext));
        _progressRepository = new Lazy<IProgressRepository>(() => new ProgressRepository(repositoryContext));
        _reviewRepository = new Lazy<IReviewRepository>(() => new ReviewRepository(repositoryContext));
        _userRepository = new Lazy<IUserRepository>(() => new UserRepository(repositoryContext));
    }
    public ICourseRepository Course => _courseRepository.Value;

    public ILessonRepository Lesson => _lessonRepository.Value;

    public IModuleRepository Module => _moduleRepository.Value;

    public IProgressRepository Progress => _progressRepository.Value;

    public IReviewRepository Review => _reviewRepository.Value;

    public IUserRepository User => _userRepository.Value;

    public void Save() => _repositoryContext.SaveChanges();
}