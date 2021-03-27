using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Guests
{
    /// <summary>
    /// Guest Reservation Entity.
    /// </summary>
    [Table("GuestReservation", Schema = "dbo")]
    public class GuestReservationEntity
    {
        /// <summary>
        /// Gets or sets the guest identifier.
        /// </summary>
        /// <value>
        /// The guest identifier.
        /// </value>
        [Required]
        [Key]
        [ForeignKey("Guest")]
        public Guid GuestId { get; set; }

        /// <summary>
        /// Gets or sets the reservation identifier.
        /// </summary>
        /// <value>
        /// The reservation identifier.
        /// </value>
        [Required]
        [Key]
        [ForeignKey("Reservation")]
        public Guid ReservationId { get; set; }
    }
}
