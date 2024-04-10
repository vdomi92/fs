using data_access_layer.Domain.Entites.Common;
using data_access_layer.Domain.Entities.Quizzes;

namespace data_access_layer.Domain.Entities.Classrooms
{
    public class HomeWork : Entity
    {
        public required string Description { get; set; }

        public required DateTime DueDate { get; set; }

        public required int AllowedAttempts { get; set; }

        public required Quiz Quiz { get; set; }

        public required Class Class { get; set; }
    }
}