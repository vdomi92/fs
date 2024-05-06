namespace fullstack_quiz_app_elte.Server.BLL.DTOS
{
    public record AnswerDTO
    {
        public required string AnswerText { get; init; }

        public bool IsCorrect { get; init; }
    }
}