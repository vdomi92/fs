using fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Quizzes;
using Microsoft.AspNetCore.Identity;

namespace fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Common
{
    public class AppUser : IdentityUser
    {
        public virtual List<Attempt> Attempts { get; set; } = [];

        public virtual List<Quiz> Quizs { get; set; } = [];
    }
}
