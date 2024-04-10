using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Domain.Entities.Quizzes
{
    public class Question : Entity
    {
        public required string QuestionText { get; set; }

        public required int Points { get; set; }

        public required bool IsMultipleChoice { get; set; }

        public List<Answer> AnswerOptions { get; set; } = [];
    }
}