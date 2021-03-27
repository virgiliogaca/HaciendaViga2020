using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Costs
{
    /// <summary>
    /// Cost Entity.
    /// </summary>
    /// <seealso cref="HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base.AuditedEntity" />
    [Table("Cost", Schema = "dbo")]
    public class CostEntity : AuditedEntity
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
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the rent type identifier.
        /// </summary>
        /// <value>
        /// The rent type identifier.
        /// </value>
        [Required]
        [ForeignKey("RentType")]
        public Guid RentTypeId { get; set; }

        /// <summary>
        /// Gets or sets the system identifier.
        /// </summary>
        /// <value>
        /// The system identifier , which assigns either a RoomId or AreaId, depending on what RentType is.
        /// </value>
        [Required]
        public Guid SystemId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is external.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is external; otherwise, <c>false</c>.
        /// </value>
        public bool IsExternal { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is weekend.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is weekend; otherwise, <c>false</c>.
        /// </value>
        public bool IsWeekend { get; set; }
    }
}
