using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Domain.Entities.Quizzes
{
    public class GivenAnswerDictionary(Question question) : Entity
    {
        public Question Key { get; set; } = question;

        public List<Answer> Value { get; set; } = [];
    }
}
