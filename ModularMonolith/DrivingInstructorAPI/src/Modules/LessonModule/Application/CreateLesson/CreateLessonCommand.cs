using MediatR;

namespace DrivingInstructorAPI.src.Modules.LessonModule.Application.CreateLesson
{
    public record CreateLessonCommand(string LessonName) : IRequest<LessonResponse>;
}
