using System;
using System.ComponentModel.DataAnnotations;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base
{
    /// <summary>
    /// Audited Entity.
    /// </summary>
    /// <seealso cref="HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base.IAuditedEntity" />
    /// <seealso cref="HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base.IEntity{System.Guid}" />
    public class AuditedEntity : IAuditedEntity, IEntity<Guid>
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Key]
        [Required]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        [Required]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        /// <value>
        /// The modified date.
        /// </value>
        [StringLength(128)]
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the activation change status.
        /// </summary>
        /// <value>
        /// The activation change status.
        /// </value>
        [StringLength(128)]
        public DateTime? ActivationChangeStatusDate { get; set; }

        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        /// <value>
        /// The created by.
        /// </value>
        [Required]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the modified by.
        /// </summary>
        /// <value>
        /// The modified by.
        /// </value>
        [StringLength(128)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the active change status by.
        /// </summary>
        /// <value>
        /// The active change status by.
        /// </value>
        [StringLength(128)]
        public string ActiveChangeStatusBy { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        [Required]
        public bool IsActive { get; set; }
    }
}
