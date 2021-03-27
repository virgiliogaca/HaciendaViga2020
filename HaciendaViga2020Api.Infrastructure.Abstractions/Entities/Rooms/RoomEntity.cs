using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Reservations
{
    /// <summary>
    /// Room Entity.
    /// </summary>
    /// <seealso cref="HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base.AuditedEntity" />
    [Table("Room", Schema = "dbo")]
    public class RoomEntity : AuditedEntity
    {
        /// <summary>
        /// Gets or sets the room type identifier.
        /// </summary>
        /// <value>
        /// The room type identifier.
        /// </value>
        [Required]
        [ForeignKey("RoomType")]
        public Guid RoomTypeId { get; set; }

        /// <summary>
        /// Gets or sets the room number.
        /// </summary>
        /// <value>
        /// The room number.
        /// </value>
        [Required]
        public int RoomNumber { get; set; }

        /// <summary>
        /// Gets or sets the room telephone.
        /// </summary>
        /// <value>
        /// The room telephone.
        /// </value>
        [Required]
        public int RoomTelephone { get; set; }
    }
}
