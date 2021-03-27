using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Inventory
{
    /// <summary>
    /// InventoryItem.
    /// </summary>
    /// <seealso cref="HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base.AuditedEntity" />
    [Table("InventoryItem", Schema = "dbo")]
    public class InventoryItemEntity : AuditedEntity
    {
        /// <summary>
        /// Gets or sets the inventory type identifier.
        /// </summary>
        /// <value>
        /// The inventory type identifier.
        /// </value>
        [Required]
        [ForeignKey("InventoryType")]
        public Guid InventoryTypeId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        /// <value>
        /// The cost.
        /// </value>
        [Required]
        public string Cost { get; set; }

        /// <summary>
        /// Gets or sets the guest cost.
        /// </summary>
        /// <value>
        /// The guest cost.
        /// </value>
        [Required]
        public string GuestCost { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is disposable.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is disposable; otherwise, <c>false</c>.
        /// </value>
        [Required]
        public bool IsDisposable { get; set; }
    }
}
