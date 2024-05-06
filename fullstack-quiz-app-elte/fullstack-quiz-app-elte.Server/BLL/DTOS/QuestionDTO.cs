namespace fullstack_quiz_app_elte.Server.BLL.DTOS
{
    public record QuestionDTO
    {
        public required string QuestionText { get; init; }

        public required int Points { get; init; }

        public required List<AnswerDTO> AnswerOptions { get; init; }
    }
}