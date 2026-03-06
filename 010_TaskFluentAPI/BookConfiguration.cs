using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _010_TaskFluentAPI
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Name == "Title");
            builder.Property(b => b.Price != 0);
            builder.Property(b => b.Pages != 0);
            builder.HasOne(p => p.Publisher)
                .WithMany(c => c.Books)
                .HasForeignKey(p => p.PublisherId);
            builder.Property(b => b.PublisherId).HasColumnName("IdPublisher");
        }
    }
}
