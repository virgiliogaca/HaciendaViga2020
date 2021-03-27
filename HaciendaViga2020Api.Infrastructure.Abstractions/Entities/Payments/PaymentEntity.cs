using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Payment
{
    /// <summary>
    /// Payment Entity.
    /// </summary>
    /// <seealso cref="HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base.AuditedEntity" />
    [Table("Payment", Schema = "dbo")]
    public class PaymentEntity : AuditedEntity
    {
        /// <summary>
        /// Gets or sets the payment method identifier.
        /// </summary>
        /// <value>
        /// The payment method identifier.
        /// </value>
        [Required]
        [ForeignKey("PaymentMethod")]
        public Guid PaymentMethodId { get; set; }

        /// <summary>
        /// Gets or sets the payment discount identifier.
        /// </summary>
        /// <value>
        /// The payment discount identifier.
        /// </value>
        [Required]
        [ForeignKey("PaymentDiscount")]
        public Guid PaymentDiscountId { get; set; }

        /// <summary>
        /// Gets or sets the quarter engagement identifier.
        /// </summary>
        /// <value>
        /// The quarter engagement identifier.
        /// </value>
        [Required]
        [ForeignKey("QuarterEngagement")]
        public Guid QuarterEngagementId { get; set; }

        /// <summary>
        /// Gets or sets the rent concept guest identifier.
        /// </summary>
        /// <value>
        /// The rent concept guest identifier.
        /// </value>
        [Required]
        [ForeignKey("RentConcept")]
        public Guid RentConceptId { get; set; }
    }
}
