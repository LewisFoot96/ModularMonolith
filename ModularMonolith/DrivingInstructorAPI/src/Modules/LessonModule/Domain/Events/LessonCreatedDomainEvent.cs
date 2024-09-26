namespace DrivingInstructorAPI.src.Modules.LessonModule.Domain.Events
{
    public sealed record LessonCreatedDomainEvent(Guid LessonId, string LessonName);
}
