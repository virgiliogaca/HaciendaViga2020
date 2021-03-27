using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Payment
{
    /// <summary>
    /// Payment Discount Entity.
    /// </summary>
    /// <seealso cref="HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base.AuditedEntity" />
    [Table("PaymentDiscount", Schema ="dbo")]
    public class PaymentDiscountEntity : AuditedEntity
    {
        /// <summary>
        /// Gets or sets the payment discount type identifier.
        /// </summary>
        /// <value>
        /// The payment discount type identifier.
        /// </value>
        [Required]
        [ForeignKey("PaymentDiscountType")]
        public Guid PaymentDiscountTypeId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the percentage.
        /// </summary>
        /// <value>
        /// The percentage.
        /// </value>
        [Required]
        public double Percentage { get; set; }
    }
}
