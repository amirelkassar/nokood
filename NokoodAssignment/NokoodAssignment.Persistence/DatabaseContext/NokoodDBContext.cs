using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NokoodAssignment.Application.Base;
using NokoodAssignment.Domain.Entities;
using NokoodAssignment.Persistence.DatabaseContext.EntityConfigurations;

namespace NokoodAssignment.Persistence.DatabaseContext
{
    public class NokoodDBContext : IdentityDbContext, INokoodDBContext
    {
        public NokoodDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new TripEntityConfiguration());
            builder.ApplyConfiguration(new ReservationEntityConfiguration());
            builder.ApplyConfiguration(new IdentityRoleEntityConfiguration());
        }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }

        public async Task<int> CommitAsync() => await SaveChangesAsync(true);
    }
}
