using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Rents
{
    /// <summary>
    /// Rent Concept Entity.
    /// </summary>
    /// <seealso cref="HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base.AuditedEntity" />
    [Table("RentConcept", Schema = "dbo")]
    public class RentConceptEntity : AuditedEntity
    {
        /// <summary>
        /// Gets or sets the system identifier defines if rent is for area or room.
        /// </summary>
        /// <value>
        /// The system identifier.
        /// </value>
        [Required]
        [ForeignKey("RoomType")]
        public Guid RentTypeId { get; set; }

        /// <summary>
        /// Gets or sets the system identifier, which assigns either a RoomId or AreaId, depending on what RentType is.
        /// </summary>
        /// <value>
        /// The system identifier.
        /// </value>
        public Guid SystemId { get; set; }
    }
}