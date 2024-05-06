using fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Common;

namespace fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Quizzes
{
    public class Attempt : Entity
    {
        public required DateTime StartTime { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime? FinishedAt { get; set; }

        public virtual List<GivenAnswer> GivenAnswers { get; set; } = [];
    }
}
