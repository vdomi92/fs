using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using data_access_layer.Domain.Entities.Quizzes;
using data_access_layer.Domain.Entites.Common;

namespace data_access_layer.Domain.Context
{
    public class ApplicationDbContext(DbContextOptions options) : IdentityDbContext<User>(options)
    {
        public DbSet<Answer> Answers { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Quiz> Quizzes { get; set; }

        public DbSet<GivenAnswer> GivenAnswers { get; set; }

        public DbSet<Attempt> Attempts { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=EduDb;Trusted_Connection=True;Encrypt=False", b => b.MigrationsAssembly("data_access_layer"));
        }
    }
}
