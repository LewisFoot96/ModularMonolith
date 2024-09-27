using DrivingInstructorAPI.src.Modules.LessonModule.Domain.Events;
using DrivingInstructorAPI.src.Modules.LessonModule.IntegrationEvents;
using MassTransit;
using MediatR;

namespace DrivingInstructorAPI.src.Modules.LessonModule.Application.CreateLesson
{
    public class LessonCreatedDomainEventHandler : INotificationHandler<LessonCreatedDomainEvent>
    {
        private readonly IBus _bus;

        public LessonCreatedDomainEventHandler(IBus bus)
        {
            _bus = bus;
        }

        public async Task Handle(LessonCreatedDomainEvent domainEvent, CancellationToken cancellationToken)
        {
            await _bus.Publish(new LessonCreatedIntegrationEvent(domainEvent.LessonName));
        }

    }
}
