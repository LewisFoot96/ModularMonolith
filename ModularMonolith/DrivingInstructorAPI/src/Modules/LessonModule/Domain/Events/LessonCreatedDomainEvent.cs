namespace DrivingInstructorAPI.src.Modules.LessonModule.Domain.Events
{
    public sealed record LessonCreatedDomainEvent(string LessonName) : IDomainEvent;
}
