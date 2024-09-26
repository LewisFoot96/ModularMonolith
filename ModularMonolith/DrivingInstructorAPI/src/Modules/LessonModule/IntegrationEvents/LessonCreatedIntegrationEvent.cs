namespace DrivingInstructorAPI.src.Modules.LessonModule.IntegrationEvents
{
    //integration events are external between modules, representing the public API
    public sealed record class LessonCreatedIntegrationEvent(Guid LessonId, string LessonName);
}
