using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Payments
{
    /// <summary>
    /// Payment Guest Entity.
    /// </summary>
    /// <seealso cref="HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base.AuditedEntity" />
    [Table("PaymentGuest", Schema = "dbo")]
    public class PaymentGuestEntity : AuditedEntity
    {
        /// <summary>
        /// Gets or sets the payment identifier.
        /// </summary>
        /// <value>
        /// The payment identifier.
        /// </value>
        [Required]
        [ForeignKey("Payment")]
        public Guid PaymentId { get; set; }

        /// <summary>
        /// Gets or sets the guest identifier.
        /// </summary>
        /// <value>
        /// The guest identifier.
        /// </value>
        [Required]
        [ForeignKey("Guest")]
        public Guid GuestId { get; set; }

        /// <summary>
        /// Gets or sets the paid amount.
        /// </summary>
        /// <value>
        /// The paid amount.
        /// </value>
        public string PaidAmount { get; set; }
    }
}
