using data_access_layer.Domain.Entites.Common;
using data_access_layer.Domain.Entities.Quizzes;

namespace data_access_layer.Domain.Entities.Classrooms
{
    public class HomeWork(string description, DateTime dueDate, int allowedAttempts) : Entity
    {
        public string Description { get; set; } = description;

        public DateTime DueDate { get; set; } = dueDate;

        public int AllowedAttempts { get; set; } = allowedAttempts;

        public List<Quiz> Quizzes { get; set; } = [];
    }
}