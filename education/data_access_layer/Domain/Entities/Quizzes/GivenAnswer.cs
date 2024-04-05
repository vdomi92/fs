using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Domain.Entities.Quizzes
{
    public class GivenAnswer: Entity
    {
        public Question Question { get; set; }

        public List<Answer> GivenAnswers { get; set; }

        public User User { get; set; }
    }
}
