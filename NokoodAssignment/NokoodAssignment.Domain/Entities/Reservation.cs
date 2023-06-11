using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NokoodAssignment.Domain.Entities
{
    public class Reservation : AuditedEntityBase<Guid>
    {
        protected Reservation()
        {
            
        }
        public Reservation([NotNull] Guid id,
            [NotNull]Guid creatorId,
            [NotNull]Guid tripId,
            [NotNull]string customerName,
            [NotNull]DateTime reservationDate)
        {
            Id = id;
            CreatorId= creatorId;
            TripId= tripId;
            CustomerName= customerName;
            ReservationDate= reservationDate;
        }
        public Guid TripId{ get;private set; }
        public string CustomerName { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Notes { get; set; }
    }
}
