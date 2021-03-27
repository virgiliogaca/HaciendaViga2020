using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Inventory
{
    /// <summary>
    /// Inventory Entity
    /// </summary>
    /// <seealso cref="HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base.AuditedEntity" />
    [Table("Inventory", Schema = "dbo")]
    public class InventoryEntity : AuditedEntity
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
        /// Gets or sets a value indicating whether this instance is recount.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is recount; otherwise, <c>false</c>.
        /// </value>
        [Required]
        public bool IsRecount { get; set; }
    }
}
