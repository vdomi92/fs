using fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Common;

namespace fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Quizzes
{
    public class Answer : Entity
    {
        public required string AnswerText { get; set; }

        public required bool IsCorrect { get; set; }

        public required Question Question { get; set; }

        public virtual List<GivenAnswer> GivenAnswers { get; set; } = [];
    }
}
