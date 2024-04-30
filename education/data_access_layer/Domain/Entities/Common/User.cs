using data_access_layer.Domain.Entities.Quizzes;
using Microsoft.AspNetCore.Identity;

namespace data_access_layer.Domain.Entites.Common
{
    public class User : IdentityUser
    {
        public virtual List<Attempt> Attempts { get; set; } = [];

        public virtual List<Quiz> Quizs { get; set; } = [];
    }
}
