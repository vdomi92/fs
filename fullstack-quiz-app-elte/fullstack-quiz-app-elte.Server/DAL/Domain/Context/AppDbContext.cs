using fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Common;
using fullstack_quiz_app_elte.Server.DAL.Domain.Entities.Quizzes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace fullstack_quiz_app_elte.Server.DAL.Domain.Context
{
    public class AppDbContext(DbContextOptions options) : IdentityDbContext<AppUser>(options)
    {
        public DbSet<Answer> Answers { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Quiz> Quizzes { get; set; }

        public DbSet<GivenAnswer> GivenAnswers { get; set; }

        public DbSet<Attempt> Attempts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //
            //  Quiz configuration
            //

            //Relationships:
            modelBuilder.Entity<Quiz>()
                .HasMany(q => q.Questions)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);


            //Properties:
            modelBuilder.Entity<Quiz>().Property(q => q.Title).IsRequired();
            modelBuilder.Entity<Quiz>().Property(q => q.Description).IsRequired();

            //
            //  Question configuration
            //

            //Relationships:
            modelBuilder.Entity<Question>()
                .HasMany(q => q.AnswerOptions)
                .WithOne(answerOption => answerOption.Question)
                .OnDelete(DeleteBehavior.Cascade);

            //Properties:
            modelBuilder.Entity<Question>().Property(q => q.QuestionText).IsRequired();
            modelBuilder.Entity<Question>().Property(q => q.Points).IsRequired();
            modelBuilder.Entity<Question>().Property(q => q.IsMultipleChoice).IsRequired();

            //
            //  Answer configuration
            //

            //Properties:
            modelBuilder.Entity<Answer>().Property(a => a.AnswerText).IsRequired();
            modelBuilder.Entity<Answer>().Property(a => a.IsCorrect).IsRequired();

            //
            //  Attempt configuration
            //

            //Relationships:
            modelBuilder.Entity<Attempt>()
                .HasMany(a => a.GivenAnswers)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            //Properties:
            modelBuilder.Entity<Attempt>().Property(a => a.StartTime).IsRequired();
            modelBuilder.Entity<Attempt>().Property(a => a.IsCompleted).IsRequired();
            modelBuilder.Entity<Attempt>().Property(a => a.FinishedAt).IsRequired(false);

            //
            //  GivenAnswer configuration
            //

        }

    }
}
