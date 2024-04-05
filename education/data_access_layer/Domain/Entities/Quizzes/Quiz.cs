using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Domain.Entities.Quizzes
{
    public class Quiz : Entity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public List<Question> Questions { get; set; }

        public User CreatedBy { get; set; }
    }
}
