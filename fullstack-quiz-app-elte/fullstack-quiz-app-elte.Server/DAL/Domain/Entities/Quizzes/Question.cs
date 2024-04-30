using fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Common;

namespace fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Quizzes
{
    public class Question : Entity
    {
        public required string QuestionText { get; set; }

        public required int Points { get; set; }

        public required bool IsMultipleChoice { get; set; }

        //public required Quiz Quiz { get; set; }

        public virtual List<Answer> AnswerOptions { get; set; } = [];
    }
}
