using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Domain.Entities.Quizzes
{
    public class Answer : Entity
    {
        public string AnswerText { get; set; }

        public bool IsCorrect { get; set; }
    }
}