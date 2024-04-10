using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Domain.Entities.Quizzes
{
    public class GivenAnswer(Quiz quiz, User user): Entity
    {
        public Dictionary<Question, List<Answer>> GivenAnswers { get; set; } = [];

        public User User { get; set; } = user;

        public Quiz Quiz { get; set; } = quiz;
    }
}
