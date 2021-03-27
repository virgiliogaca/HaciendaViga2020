using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Taxes
{
    /// <summary>
    /// Tax Cost Entity.
    /// </summary>
    /// <seealso cref="HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base.AuditedEntity" />
    [Table("TaxCost", Schema = "dbo")]
    public class TaxCostEntity : AuditedEntity
    {
        /// <summary>
        /// Gets or sets the tax identifier.
        /// </summary>
        /// <value>
        /// The tax identifier.
        /// </value>
        [Required]
        [ForeignKey("Tax")]
        public Guid TaxId { get; set; }

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
