using DrivingInstructorAPI.src.Modules.LessonModule.Domain.Events;

namespace DrivingInstructorAPI.src.Modules.LessonModule.Domain
{
    public sealed class Lesson
    {
        public  Guid LessonId { get; private set; }
        public string LessonName { get; private set; } = string.Empty;

        private static readonly List<IDomainEvent> _domainEvents = [];

        public static Lesson Create(string lessonDescription)
        {
            //Raise a domain event 
            var newLesson = new Lesson()
            {
                LessonId = Guid.NewGuid(),
                LessonName = lessonDescription,
            };

            return newLesson;
        }

        private static void RaiseDomainEvent(LessonCreatedDomainEvent lessonCreatedDomainEvent) => _domainEvents.Add(lessonCreatedDomainEvent);
    }
}
