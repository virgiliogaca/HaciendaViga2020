using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Reservations
{
    /// <summary>
    /// Room Type Entity.
    /// </summary>
    /// <seealso cref="HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base.AuditedEntity" />
    [Table("RoomType", Schema = "dbo")]
    public class RoomTypeEntity : AuditedEntity
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the room amount.
        /// </summary>
        /// <value>
        /// The room amount.
        /// </value>
        [Required]
        public int RoomAmount { get; set; }
    }
}
