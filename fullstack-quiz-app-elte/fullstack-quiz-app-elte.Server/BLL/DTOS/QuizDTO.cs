namespace fullstack_quiz_app_elte.Server.BLL.DTOS
{
    public record QuizDTO
    {
        public required string Title { get; init; }

        public required string Description { get; init; }

        public required List<QuestionDTO> Questions { get; init; }
    }
}
