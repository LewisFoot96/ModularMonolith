namespace DrivingInstructorAPI.src.Modules.LessonModule.IntegrationEvents
{
    //integration events are external between modules, representing the public API
    //Only things allowed to leave module
    public sealed record class LessonCreatedIntegrationEvent(string LessonName);
}
