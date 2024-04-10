using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Domain.Entities.Quizzes
{
    public class Quiz(User createdBy, string description, string title) : Entity
    {
        public string Title { get; set; } = title;

        public string Description { get; set; } = description;

        public List<Question> Questions { get; set; } = [];

        public User CreatedBy { get; set; } = createdBy;
    }
}
