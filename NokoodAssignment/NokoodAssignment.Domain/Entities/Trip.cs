using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NokoodAssignment.Domain.Entities
{
    public class Trip : AuditedEntityBase<Guid>
    {
        protected Trip() { }
        public Trip(
            [NotNull]Guid id,
            [NotNull]Guid creatorId,
            [NotNull]string name,
            [NotNull]string cityName,
            [NotNull]double price,
            [NotNull]string imgUrl,
            [NotNull]string content)
        {
            Id = id;
            CreationDate = DateTime.Now;
            CreatorId = creatorId;
            Name = name;
            CityName= cityName;
            Price = price;
            ImageUrl = imgUrl;
            Content = content;
            Reservations = new HashSet<Reservation>();
        }
        public string Name { get; set; }
        public string CityName { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public string? Notes { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
