using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Inventory
{
    /// <summary>
    /// Area Inventory Item Entity.
    /// </summary>
    /// <seealso cref="HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base.AuditedEntity" />
    [Table("AreaInventoryItem", Schema = "dbo")]
    public class AreaInventoryItemEntity : AuditedEntity
    {
        /// <summary>
        /// Gets or sets the area identifier.
        /// </summary>
        /// <value>
        /// The area identifier.
        /// </value>
        [Required]
        [ForeignKey("Area")]
        public Guid AreaId { get; set; }

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
        /// Gets or sets the items used.
        /// </summary>
        /// <value>
        /// The items used.
        /// </value>
        [Required]
        public int ItemsUsed { get; set; }
    }
}
