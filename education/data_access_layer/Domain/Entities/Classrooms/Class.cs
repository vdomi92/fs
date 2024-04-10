using data_access_layer.Domain.Entites.Common;
using Microsoft.AspNetCore.Identity;

namespace data_access_layer.Domain.Entities.Classrooms
{
    public class Class : Entity
    {
        public required string Name { get; set; }

        public List<User> Students { get; set; } = [];

        public required User Teacher { get; set; }

        public List<HomeWork> HomeWorks { get; set; } = [];
    }
}
