using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Domain.Entities.Quizzes
{
    public class GivenAnswer(Quiz quiz, User user, GivenAnswerDictionary givenAnswerDictionary) : Entity
    {
        public GivenAnswerDictionary GivenAnswerDictionary { get; set; } = givenAnswerDictionary;

        public User User { get; set; } = user;

        public Quiz Quiz { get; set; } = quiz;
    }
}
