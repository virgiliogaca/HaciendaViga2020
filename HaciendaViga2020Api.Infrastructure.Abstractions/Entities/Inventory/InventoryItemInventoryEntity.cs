using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Inventory
{
    /// <summary>
    /// Inventory Item Inventory Entity.
    /// </summary>
    /// <seealso cref="HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base.AuditedEntity" />
    public class InventoryItemInventoryEntity : AuditedEntity
    {
        /// <summary>
        /// Gets or sets the inventory item identifier.
        /// </summary>
        /// <value>
        /// The inventory item identifier.
        /// </value>
        [ForeignKey("InventoryItem")]
        [Required]
        public Guid InventoryItemId { get; set; }

        /// <summary>
        /// Gets or sets the inventory identifier.
        /// </summary>
        /// <value>
        /// The inventory identifier.
        /// </value>
        [ForeignKey("Inventory")]
        [Required]
        public Guid InventoryId { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        [Required]
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets the date of arrival.
        /// </summary>
        /// <value>
        /// The date of arrival.
        /// </value>
        [Required]
        public DateTime DateOfArrival { get; set; }
    }
}
