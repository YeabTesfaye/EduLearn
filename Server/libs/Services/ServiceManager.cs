using Contracts;
using Service.Contracts;

namespace Services;

public class ServiceManager : IServiceManager
{
    private readonly Lazy<ICourseService> _courseService;
    private readonly Lazy<IUserService> _userService;
    private readonly Lazy<ILessonService> _lessonService;
    private readonly Lazy<IModuleService> _moduleService;
    private readonly Lazy<IProgressService> _progressService;
    private readonly Lazy<IReviewService> _reviewService;

    public ServiceManager(IRepositoryManager repositoryManager)
    {
        _courseService = new Lazy<ICourseService>(() => new CourseService(repositoryManager));
        _userService = new Lazy<IUserService>(() => new UserService(repositoryManager));
        _lessonService = new Lazy<ILessonService>(() => new LessonService(repositoryManager));
        _moduleService = new Lazy<IModuleService> ( () => new ModuleService(repositoryManager));
        _progressService = new Lazy<IProgressService> ( () => new ProgressService(repositoryManager));
        _reviewService = new Lazy<IReviewService> ( () => new ReviewService(repositoryManager));
    }
 

    public ICourseService CourseService => _courseService.Value;

    public ILessonService LessonService => _lessonService.Value;

    public IModuleService ModuleService => _moduleService.Value;

    public IProgressService ProgressService => _progressService.Value;

    public IReviewService ReviewService => _reviewService.Value;

    public IUserService UserService => _userService.Value;

}
