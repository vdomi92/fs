using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using data_access_layer.Domain.Entities.Quizzes;
using data_access_layer.Domain.Entities.Classrooms;

namespace data_access_layer.Domain.Context
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        //public ApplicationDbContext()
        //{
        //     THIS SHIT SHOULD NOT BE HERE WHY CANT PROPER SERVICE REGISTRATION WORK???????????????????
        //}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {
            //Unable to create a 'DbContext' of type ''. The exception 'No database provider has been configured for this DbContext.
            //A provider can be configured by overriding the 'DbContext.OnConfiguring' method or by using 'AddDbContext' on the application service provider.
            //If 'AddDbContext' is used, then also ensure that your DbContext type accepts a DbContextOptions<TContext> object in its constructor
            //and passes it to the base constructor for DbContext.' was thrown while attempting to create an instance. For the different patterns supported at design time,
            //see https://go.microsoft.com/fwlink/?linkid=851728

            //LIKE BRO PLEASE
        }

        public DbSet<Answer> Answers { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Quiz> Quizzes { get; set; }

        public DbSet<GivenAnswer> GivenAnswers { get; set; }

        public DbSet<GivenAnswerDictionary> GivenAnswerDictionaries { get; set; }

        public DbSet<Class> Classes { get; set; }

        public DbSet<HomeWork> HomeWorks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EduDb;Trusted_Connection=True;Encrypt=False", b => b.MigrationsAssembly("data_access_layer"));
            // WHY THO PLS GOD HELP ME I WANT TO KILL MYSELF THANKS
            // EMPTY CONSTRUCTOR + ONCONFIGURING USESQLSERVER = MIGRATION WORKS
            // SERVICE REGISTRATION IN PROGRAM.CS = MIGRATION GETFUCKED
        }
    }
}
