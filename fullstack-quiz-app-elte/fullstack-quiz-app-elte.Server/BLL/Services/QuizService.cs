using fullstack_quiz_app_elte.Server.BLL.Contracts;
using fullstack_quiz_app_elte.Server.DAL.Contracts;
using fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Quizzes;

namespace fullstack_quiz_app_elte.Server.BLL.Services
{
    public class QuizService: IQuizService
    {
        private readonly IRepository<Quiz> _quizRepository;

        public QuizService(IRepository<Quiz> quizRepository)
        {
            _quizRepository = quizRepository;
        }

        public void CreateQuiz(Quiz quiz)
        {
             _quizRepository.Create(quiz);
        }

        public void SaveChanges()
        {
             _quizRepository.SaveChanges();
        }
    }
}
