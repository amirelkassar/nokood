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
    public class ReservationEntityConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.ToTable($"{NokoodConsts.AppDBTables_Prefix}{nameof(Reservation)}");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.CreatorId)
                   .IsRequired();

            builder.Property(r => r.CreationDate)
                   .IsRequired();

            builder.Property(r => r.TripId)
                .IsRequired();

            builder.Property(r => r.CustomerName)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(r => r.ReservationDate)
                .IsRequired();
        }
    }
}
