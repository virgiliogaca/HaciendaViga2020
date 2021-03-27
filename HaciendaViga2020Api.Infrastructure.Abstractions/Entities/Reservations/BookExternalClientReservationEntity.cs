using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Reservations
{
    /// <summary>
    /// Book External Client Reservation Entity.
    /// </summary>
    [Table("BookExternalClientReservation", Schema = "dbo")]
    public class BookExternalClientReservationEntity
    {
        /// <summary>
        /// Gets or sets the external client catalog identifier.
        /// </summary>
        /// <value>
        /// The external client catalog identifier.
        /// </value>
        [Required]
        [Key]
        [ForeignKey("ExternalClientCatalog")]
        public Guid ExternalClientCatalogId { get; set; }

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
