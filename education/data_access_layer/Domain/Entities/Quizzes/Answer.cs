using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Domain.Entities.Quizzes
{
    public class Answer(string answerText, bool isCorrect) : Entity
    {
        public string AnswerText { get; set; } = answerText;

        public bool IsCorrect { get; set; } = isCorrect;
    }
}