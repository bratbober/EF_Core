using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _010_TaskFluentAPI
{
    public class AutorConfiguration : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.ToTable("Autors");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(a => a.Surname).HasColumnName("LastName").HasMaxLength(50).IsRequired();
            builder
                .HasMany(b => b.Books)
                .WithMany(a => a.Authors)
                .UsingEntity<Dictionary<string, object>>("BookAuthors");


        }
    }
}
