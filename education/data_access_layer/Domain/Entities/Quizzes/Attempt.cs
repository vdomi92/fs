using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Domain.Entities.Quizzes
{
    public class Attempt : Entity
    {
        public required DateTime StartTime { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime? FinishedAt { get; set; }

        //public required User User { get; set; }

        public virtual List<GivenAnswer> GivenAnswers { get; set; } = [];

    }
}
