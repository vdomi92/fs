using data_access_layer.Domain.Entities.Classrooms;
using Microsoft.AspNetCore.Identity;

namespace data_access_layer.Domain.Entites.Common
{
    public class User : IdentityUser
    {
        public List<Class> TeacherInClasses { get; set; } = [];

        public List<Class> StudentInClasses { get; set; } = [];
    }
}
