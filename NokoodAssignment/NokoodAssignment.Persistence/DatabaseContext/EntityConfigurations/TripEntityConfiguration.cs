using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NokoodAssignment.Domain.Consts;
using NokoodAssignment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NokoodAssignment.Persistence.DatabaseContext.EntityConfigurations
{
    public class TripEntityConfiguration : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.ToTable($"{NokoodConsts.AppDBTables_Prefix}{nameof(Trip)}");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.CreatorId)
                   .IsRequired();

            builder.Property(t => t.CreationDate)
                   .IsRequired();

            builder.HasMany(t => t.Reservations)
                .WithOne()
                .HasForeignKey(r => r.TripId);

            builder.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(t => t.CityName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(t => t.Price)
                .IsRequired();

            builder.Property(t => t.ImageUrl)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(t => t.Content)
                .IsRequired();

            builder.Property(t => t.Notes)
                .IsRequired(false)
                .HasMaxLength(500);

            SeedTrips(builder);
        }

        private void SeedTrips(EntityTypeBuilder<Trip> builder)
        {
            var tripFaker = new Faker<Trip>()
                .RuleFor(t => t.Id, f => f.Random.Uuid())
                .RuleFor(t => t.Name, f => f.Random.Word())
                .RuleFor(t => t.CityName, f => f.Address.City())
                .RuleFor(t => t.Price, f => Convert.ToDouble(f.Commerce.Price()))
                .RuleFor(t => t.ImageUrl, f => f.Image.LoremPixelUrl())
                .RuleFor(t => t.Content, f => f.Random.Words(60))
                .RuleFor(t=>t.CreationDate,f=>f.Date.Recent())
                .RuleFor(t=>t.CreatorId,f=>Guid.Parse("78A7570F-3CE5-48BA-9461-80283ED1D94D"));

            builder.HasData(tripFaker.Generate(count: 15));


        }
    }
}
