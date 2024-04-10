using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Domain.Entities.Quizzes
{
    public class Question(string questionText, int points) : Entity
    {
        public string QuestionText { get; set; } = questionText;

        public int Points { get; set; } = points;

        public List<Answer> AnswerOptions { get; set; } = [];
    }
}