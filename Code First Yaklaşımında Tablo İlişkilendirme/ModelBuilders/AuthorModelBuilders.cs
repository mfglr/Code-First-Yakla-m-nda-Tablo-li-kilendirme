using Code_First_Yaklaşımında_Tablo_İlişkilendirme.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Code_First_Yaklaşımında_Tablo_İlişkilendirme.ModelBuilders
{
    public class AuthorModelBuilders : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder
                .HasMany(x => x.Books)
                .WithOne(x => x.Author)
                .HasForeignKey(x => x.AuthorId);
        }
    }
}
