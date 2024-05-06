using fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Quizzes;

namespace fullstack_quiz_app_elte.Server.BLL.Contracts
{
    public interface IQuizService
    {
        public void CreateQuiz(Quiz quiz);

        public void SaveChanges();
    }
}
