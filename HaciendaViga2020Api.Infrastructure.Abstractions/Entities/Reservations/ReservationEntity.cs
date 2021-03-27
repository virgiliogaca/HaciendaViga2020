using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Reservations
{
    /// <summary>
    /// Reservation Entity.
    /// </summary>
    /// <seealso cref="HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base.AuditedEntity" />
    [Table("Reservation", Schema = "dbo")]
    public class ReservationEntity : AuditedEntity
    {
        /// <summary>
        /// Gets or sets the room identifier.
        /// </summary>
        /// <value>
        /// The room identifier.
        /// </value>
        [Required]
        [ForeignKey("Room")]
        public Guid RoomId { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        [Required]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        [Required]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is canceled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is canceled; otherwise, <c>false</c>.
        /// </value>
        public bool IsCanceled { get; set; }

        /// <summary>
        /// Gets or sets the canceled by.
        /// </summary>
        /// <value>
        /// The canceled by.
        /// </value>
        public string CanceledBy { get; set; }

        /// <summary>
        /// Gets or sets the cancelation date.
        /// </summary>
        /// <value>
        /// The cancelation date.
        /// </value>
        public DateTime CancelationDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is external client.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is external client; otherwise, <c>false</c>.
        /// </value>
        [Required]
        public bool IsExternalClient { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is payed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is payed; otherwise, <c>false</c>.
        /// </value>
        [Required]
        public bool IsPayed { get; set; }
    }
}
