using Core.Entities.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            //1-1 order item and item ordered
            builder.OwnsOne(i => i.ItemOrdered, io => { io.WithOwner(); });
            //set price as decimal field
            builder.Property(i => i.Price).HasColumnType("decimal(18,2)");

        }
    }
}