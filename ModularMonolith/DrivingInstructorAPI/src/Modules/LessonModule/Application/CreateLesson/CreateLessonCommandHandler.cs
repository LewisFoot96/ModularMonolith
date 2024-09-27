using DrivingInstructorAPI.src.Modules.LessonModule.Domain;
using DrivingInstructorAPI.src.Modules.LessonModule.Domain.Events;
using MediatR;

namespace DrivingInstructorAPI.src.Modules.LessonModule.Application.CreateLesson
{
    public class CreateLessonCommandHandler : IRequestHandler<CreateLessonCommand, LessonResponse>
    {
        public async Task<LessonResponse> Handle(CreateLessonCommand request, CancellationToken cancellationToken)
        {
            //Would likly have some async processing in the handler. 
            //Do something with the request

            Lesson.Create(request.LessonName);

            RaiseDomainEvent(new LessonCreatedDomainEvent("Lewis"));
            //lesson

            //var newLesson = lesson.Create(request.LessonName);

            return new LessonResponse.Success(request.LessonName, "Nice lesson");

        }
    }
}
