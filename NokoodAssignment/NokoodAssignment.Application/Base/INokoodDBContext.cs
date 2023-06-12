using Microsoft.EntityFrameworkCore;
using NokoodAssignment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NokoodAssignment.Application.Base
{
    public interface INokoodDBContext
    {
        DbSet<Trip> Trips { get; set; }
        DbSet<Reservation> Reservations { get; set; }
        Task<int> CommitAsync();
    }
}
