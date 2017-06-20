using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Data;

namespace aspnetcoreapp
{
    public class DatabaseContext : DbContext
    {
        private readonly IConfigurationRoot _config;

        public DatabaseContext()
        {

        }

        public DatabaseContext(IConfigurationRoot config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=Ankieter;Integrated Security=True;");
        }

        public DbSet<AnswerEntity> AnswerSet { get; set; }
        public DbSet<QuestionEntity> QuestionSet { get; set; }
        public DbSet<QuestionareEntity> QuestionareSet { get; set; }
        public DbSet<QuestionOptionEntity> QuestionOptionSet { get; set; }

    }
}
