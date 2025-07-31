using Code_First_Yaklaşımında_Tablo_İlişkilendirme.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Code_First_Yaklaşımında_Tablo_İlişkilendirme.ModelBuilders
{
    public class UserModelBuilders : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasMany(x => x.Posts)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);
        }
    }
}
