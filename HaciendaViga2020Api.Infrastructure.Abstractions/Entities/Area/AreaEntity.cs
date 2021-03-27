using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Area
{
    /// <summary>
    /// Area Entity.
    /// </summary>
    /// <seealso cref="HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base.AuditedEntity" />
    [Table("Area", Schema = "dbo")]
    public class AreaEntity : AuditedEntity
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
        /// Gets or sets the prople amount.
        /// </summary>
        /// <value>
        /// The prople amount.
        /// </value>
        [Required]
        public int PropleAmount { get; set; }
    }
}
