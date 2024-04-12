using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using data_access_layer.Domain.Entities.Quizzes;
using data_access_layer.Domain.Entities.Classrooms;
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

        public DbSet<Class> Classes { get; set; }

        public DbSet<HomeWork> HomeWorks { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Class>()
        //        .HasOne(c => c.Teacher)
        //        .WithMany(t => t.TeacherInClasses)
        //        .HasForeignKey(t => t.Id);

        //    modelBuilder.Entity<Class>()
        //        .HasMany(c => c.Students)
        //        .WithMany(t => t.StudentInClasses)
        //        .UsingEntity(join => join.ToTable("StudentClass"));

        //    modelBuilder.Entity<Class>()
        //        .HasMany(c => c.HomeWorks)
        //        .WithOne(hw => hw.Class)
        //        .HasForeignKey(hw => hw.Id);

        //}
    }
}
