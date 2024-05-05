using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp1.Data
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Studenci");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Imie).IsRequired();
            builder.Property(x => x.Nazwisko).IsRequired();
            builder.Property(x => x.Email).IsRequired(false);
        }
    }

    public class PrzedmiotConfiguration : IEntityTypeConfiguration<Przedmiot>
    {
        public void Configure(EntityTypeBuilder<Przedmiot> builder)
        {
            builder.ToTable("Przedmioty");
            builder.HasKey(x => x.Id);
        }
    }

    public class ZapisaniaConfiguration : IEntityTypeConfiguration<Zapisanie>
    {
        public void Configure(EntityTypeBuilder<Zapisanie> builder)
        {
            builder.ToTable("Zapisania");
            builder.HasKey(x => x.Id);
        }
    }

    public class OcenaConfiguration : IEntityTypeConfiguration<Ocena>
    {
        public void Configure(EntityTypeBuilder<Ocena> builder)
        {
            builder.ToTable("Oceny");
            builder.HasKey(x => x.Id);
        }
    }
}
