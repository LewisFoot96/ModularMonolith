using MassTransit;
using MessageContracts;

namespace DrivingInstructorAPI.src.Modules.InstructorModule.Infrastructure
{
    public class LessonCreatedConsumer : IConsumer<CreateLessonMessage>
    {
        public Task Consume(ConsumeContext<CreateLessonMessage> context)
        {
            //Would likely have a handler on the back of this to process the message and do something with it
            Console.WriteLine("Hello " + context.Message.Name);
            return Task.CompletedTask;
        }
    }
}
