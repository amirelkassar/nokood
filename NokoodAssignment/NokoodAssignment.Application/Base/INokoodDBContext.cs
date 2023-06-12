using Microsoft.EntityFrameworkCore;
using NokoodAssignment.Domain.Entities;

namespace NokoodAssignment.Application.Base
{
    public interface INokoodDBContext
    {
        DbSet<Trip> Trips { get; set; }
        DbSet<Reservation> Reservations { get; set; }
        Task<int> CommitAsync();
    }
}
