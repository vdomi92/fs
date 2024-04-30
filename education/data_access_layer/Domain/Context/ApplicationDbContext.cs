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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Class>()
            //    .HasOne(c => c.Teacher)
            //    .WithMany(t => t.TeacherInClasses)
            //    .HasForeignKey(t => t.Id);

            //modelBuilder.Entity<Class>()
            //    .HasMany(c => c.Students)
            //    .WithMany(t => t.StudentInClasses)
            //    .UsingEntity(join => join.ToTable("StudentClass"));

            //modelBuilder.Entity<Class>()
            //    .HasMany(c => c.HomeWorks)
            //    .WithOne(hw => hw.Class)
            //    .HasForeignKey(hw => hw.Id);

        //    modelBuilder.Entity<Class>()
        //        .HasMany(c => c.HomeWorks)
        //        .WithOne(hw => hw.Class)
        //        .HasForeignKey(hw => hw.Id);

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EduDb;Trusted_Connection=True;Encrypt=False", b => b.MigrationsAssembly("data_access_layer"));
            // WHY THO PLS GOD HELP ME I WANT TO KILL MYSELF THANKS
            // EMPTY CONSTRUCTOR + ONCONFIGURING USESQLSERVER = MIGRATION WORKS
            // SERVICE REGISTRATION IN PROGRAM.CS = MIGRATION GETFUCKED
        }
    }
}
