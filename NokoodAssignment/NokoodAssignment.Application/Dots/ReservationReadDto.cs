using NokoodAssignment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NokoodAssignment.Application.Dots
{
    public class ReservationReadDto
    {
        public Guid TripId { get;  set; }
        public string CustomerName { get; set; }
        public DateTime ReservationDate { get; set; }
        public string? Notes { get; set; }

        public static explicit operator ReservationReadDto(Reservation input)
        {
            var readDto = new ReservationReadDto()
            {
                CustomerName = input.CustomerName,
                TripId = input.TripId,
                Notes = input.Notes,
                ReservationDate = input.ReservationDate
            };
            return readDto;
        }
    }
}
