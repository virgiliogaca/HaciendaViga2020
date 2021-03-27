using System;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base
{
    /// <summary>
    /// Audited Entity Interface .
    /// </summary>
    public interface IAuditedEntity
    {
        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        /// <value>
        /// The modified date.
        /// </value>
        DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the activation change status.
        /// </summary>
        /// <value>
        /// The activation change status.
        /// </value>
        DateTime? ActivationChangeStatusDate { get; set; }

        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        /// <value>
        /// The created by.
        /// </value>
        string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the modified by.
        /// </summary>
        /// <value>
        /// The modified by.
        /// </value>
        string ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the active change status by.
        /// </summary>
        /// <value>
        /// The active change status by.
        /// </value>
        string ActiveChangeStatusBy { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        bool IsActive { get; set; }
    }
}
