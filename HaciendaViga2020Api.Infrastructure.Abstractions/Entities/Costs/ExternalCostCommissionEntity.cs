using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Costs
{
    /// <summary>
    /// External Cost Commission Entity.
    /// </summary>
    /// <seealso cref="HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base.AuditedEntity" />
    [Table("ExternalCostCommission", Schema = "dbo")]
    public class ExternalCostCommissionEntity : AuditedEntity
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        /// <value>
        /// The cost.
        /// </value>
        public string Cost { get; set; }

        /// <summary>
        /// Gets or sets the external client catalog identifier.
        /// </summary>
        /// <value>
        /// The external client catalog identifier.
        /// </value>
        [Required]
        [ForeignKey("ExternalClientCatalog")]
        public Guid ExternalClientCatalogId { get; set; }

        /// <summary>
        /// Gets or sets the cost identifier.
        /// </summary>
        /// <value>
        /// The cost identifier.
        /// </value>
        [Required]
        [ForeignKey("Cost")]
        public Guid CostId { get; set; }
    }
}
