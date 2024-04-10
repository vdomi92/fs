using data_access_layer.Domain.Entites.Common;
using data_access_layer.Domain.Entities.Classrooms;

namespace data_access_layer.Domain.Entities.Quizzes
{
    public class Attempt : Entity
    {
        public required User User { get; set; }

        public required HomeWork HomeWork { get; set; }

        public required DateTime AnsweredAt { get; set; }

        public List<GivenAnswer> GivenAnswers { get; set; } = [];
    }
}
