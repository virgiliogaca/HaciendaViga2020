using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Inventory
{
    /// <summary>
    /// Room Inventory Item Entity.
    /// </summary>
    /// <seealso cref="HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base.AuditedEntity" />
    [Table("RoomInventoryItem", Schema = "dbo")]
    public class RoomInventoryItemEntity : AuditedEntity
    {
        /// <summary>
        /// Gets or sets the inventory item identifier.
        /// </summary>
        /// <value>
        /// The inventory item identifier.
        /// </value>
        [Required]
        [ForeignKey("InventoryItem")]
        public Guid InventoryItemId { get; set; }

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
        /// Gets or sets the items used.
        /// </summary>
        /// <value>
        /// The items used.
        /// </value>
        [Required]
        public int ItemsUsed { get; set; }

        /// <summary>
        /// Gets or sets the amount per room.
        /// </summary>
        /// <value>
        /// The amount per room.
        /// </value>
        [Required]
        public int AmountPerRoom { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is missing.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is missing; otherwise, <c>false</c>.
        /// </value>
        [Required]
        public bool IsMissing { get; set; }
    }
}
