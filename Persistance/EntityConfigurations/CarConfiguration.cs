using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public partial class ModelConfiguration
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars").HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.ModelId).HasColumnName("ModelId").IsRequired();
            builder.Property(c => c.Kilometer).HasColumnName("Kilometer").IsRequired();
            builder.Property(c => c.CarState).HasColumnName("CarState");
            builder.Property(c => c.ModelYear).HasColumnName("ModelYear");


            builder.HasOne(c => c.Model);

            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        }
    }
}