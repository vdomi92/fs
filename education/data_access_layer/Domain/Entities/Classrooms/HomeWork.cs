using data_access_layer.Domain.Entites.Common;
using data_access_layer.Domain.Entities.Quizzes;

namespace data_access_layer.Domain.Entities.Classrooms
{
    public class HomeWork : Entity
    {
        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public int AllowedAttempts { get; set; }

        public List<Quiz> Quizzes { get; set; }
    }
}