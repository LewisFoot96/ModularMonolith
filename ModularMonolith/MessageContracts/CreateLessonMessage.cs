namespace MessageContracts
{
    public record CreateLessonMessage
    {
        public string Name { get; init; } = string.Empty;
    }
}
