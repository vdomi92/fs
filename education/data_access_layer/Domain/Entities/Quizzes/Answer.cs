using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Domain.Entities.Quizzes
{
    public class Answer: Entity
    {
        public required string AnswerText { get; set; }

        public required bool IsCorrect { get; set; }

        public required Question Question { get; set; }
    }
}