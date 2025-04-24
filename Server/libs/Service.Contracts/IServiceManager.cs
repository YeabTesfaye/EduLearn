

namespace Service.Contracts;

public interface IServiceManager
{
    ICourseService CourseService { get; }
    ILessonService LessonService { get; }
    IModuleService ModuleService {get;}
    IProgressService ProgressService {get;}
    IReviewService ReviewService {get;}
    IUserService UserService {get;}

}