using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Domain.Entities.Quizzes
{
    public class Question : Entity
    {
        public string QuestionText { get; set; }

        public int Points { get; set; }
        
        public List<Answer> AnswerOptions { get; set; }
    }
}