using DrivingInstructorAPI.src.Modules.LessonModule.Domain;
using MediatR;

namespace DrivingInstructorAPI.src.Modules.LessonModule.Application.CreateLesson
{
    public class CreateLessonCommandHandler : IRequestHandler<CreateLessonCommand, LessonResponse>
    {
        public async Task<LessonResponse> Handle(CreateLessonCommand request, CancellationToken cancellationToken)
        {
            //Would likly have some async processing in the handler. 
            //Do something with the request

            var lesson = new Lesson();
            //lesson

            //var newLesson = lesson.Create(request.LessonName);

            return new LessonResponse.Success(request.LessonName, "Nice lesson");

        }
    }
}
