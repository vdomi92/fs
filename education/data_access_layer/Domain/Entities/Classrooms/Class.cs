using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Domain.Entities.Classrooms
{
    public class Class(string name, User teacher) : Entity
    {
        public string Name { get; set; } = name;

        public List<User> Students { get; set; } = [];

        public User Teacher { get; set; } = teacher;

        public List<HomeWork> HomeWorks { get; set; } = [];
    }
}
