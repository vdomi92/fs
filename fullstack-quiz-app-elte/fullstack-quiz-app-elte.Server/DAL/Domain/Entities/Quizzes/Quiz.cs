using fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Common;

namespace fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Quizzes
{
    public class Quiz : Entity
    {
        public required string Title { get; set; }

        public required string Description { get; set; }

        //public required User CreatedBy { get; set; }

        public virtual List<Question> Questions { get; set; } = [];

    }
}
