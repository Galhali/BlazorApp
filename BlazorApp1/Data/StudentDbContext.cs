using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class StudentDbContext : DbContext
    {
        protected readonly IConfiguration configuration;

        public StudentDbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(configuration.GetConnectionString("StudentDB"));
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Ocena> Oceny { get; set; }
        public DbSet<Przedmiot> Przedmioty { get; set;}
        public DbSet<Zapisanie> Zapisania { get; set;}
    }
}
