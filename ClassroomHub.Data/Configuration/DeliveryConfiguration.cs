using ClassroomHub.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassroomHub.Data.Configuration
{
    internal class DeliveryConfiguration : IEntityTypeConfiguration<Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DeliveyDate).IsRequired();
            builder.Property(x => x.Resolution).IsRequired();
            builder.HasOne(x => x.Student).WithMany(x => x.Deliveries).OnDelete(DeleteBehavior.NoAction);            
            builder.HasOne(x => x.Activity).WithMany(x => x.Deliveries).OnDelete(DeleteBehavior.NoAction);            
        }
    }
}
