
using DrivingInstructorAPI.src.Modules.LessonModule.Application.CreateLesson;
using MediatR;

namespace DrivingInstructorAPI.src.Modules.LessonModule.Endpoints
{
    public static class LessonEndpoints
    {
        public static void MapLessonEndpoints(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("api/lesson");
            //Minimal apis use method injection
            group.MapPost("", CreateLesson);

            //group.MapGet("{id}", GetLesson);
        }

        public static async Task<IResult> CreateLesson(string lessonName, IMediator sender)
        {
            var result = await sender.Send(new CreateLessonCommand(lessonName));

            return result.Match<IResult>(
                success => TypedResults.NoContent(),
                failure => TypedResults.BadRequest(failure.Message));
        }
    }
}
