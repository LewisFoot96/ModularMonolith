namespace DrivingInstructorAPI.src.Modules.Lesson.Domain.Events
{
    public sealed record LessonCreatedDomainEvent(Guid LessonId, string LessonName);
}
