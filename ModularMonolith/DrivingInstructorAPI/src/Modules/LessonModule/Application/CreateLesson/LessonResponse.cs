using OneOf;

namespace DrivingInstructorAPI.src.Modules.LessonModule.Application.CreateLesson
{
    [GenerateOneOf]
    public partial class LessonResponse : OneOfBase<LessonResponse.Success,
        LessonResponse.Failure>
    {
        public record Success(string Value, string Message);
        public record Failure(string Message);
    }
}
