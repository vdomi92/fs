using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Domain.Entities.Quizzes
{
    public class Quiz : Entity
    {
        public required string Title { get; set; }

        public required string Description { get; set; }

        public required User CreatedBy { get; set; }

        public virtual List<Question> Questions { get; set; } = [];

    }
}
