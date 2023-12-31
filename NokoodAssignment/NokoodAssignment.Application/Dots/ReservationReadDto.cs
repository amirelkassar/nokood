﻿using NokoodAssignment.Domain.Entities;

namespace NokoodAssignment.Application.Dots
{
    public class ReservationReadDto
    {
        public Guid Id { get; set; }
        public Guid TripId { get; set; }
        public string CustomerName { get; set; }
        public DateTime ReservationDate { get; set; }
        public string? Notes { get; set; }

        public static explicit operator ReservationReadDto(Reservation input)
        {
            var readDto = new ReservationReadDto()
            {
                Id = input.Id,
                CustomerName = input.CustomerName,
                TripId = input.TripId,
                Notes = input.Notes,
                ReservationDate = input.ReservationDate
            };
            return readDto;
        }
    }
}
