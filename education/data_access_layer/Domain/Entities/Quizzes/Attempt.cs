using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Domain.Entities.Quizzes
{
    public class Attempt : Entity
    {
        public required User User { get; set; }

        public required DateTime StartTime { get; set; }

        public DateTime? FinishedAt { get; set; }

        public List<GivenAnswer> GivenAnswers { get; set; } = [];

        public bool IsCompleted { get; set; }
    }
}
