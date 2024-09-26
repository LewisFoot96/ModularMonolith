namespace DrivingInstructorAPI.src.Modules.LessonModule.Domain
{
    public sealed class Lesson
    {
        public  Guid LessonId { get; private set; }
        public string LessonName { get; private set; } = string.Empty;

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
    }
}
