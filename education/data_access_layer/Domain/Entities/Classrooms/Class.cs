using data_access_layer.Domain.Entites.Common;
using data_access_layer.Domain.Entities.Quizzes;

namespace data_access_layer.Domain.Entities.Classrooms
{
    public class Class : Entity
    {
        public string Name { get; set; }

        public List<User> Students { get; set; }

        public User Teacher { get; set; }

        public List<Quiz> Quizzes { get; set; }

        public List<HomeWork> Tasks { get; set; }
    }
}
