using System;
using System.Collections.Generic;
using System.Text;

namespace HaciendaViga2020Api.Infrastructure.Abstractions.Entities.Base
{
    /// <summary>
    /// Entity
    /// </summary>
    /// <typeparam name="T">Represents entity for which will construct an Id.</typeparam>
    public interface IEntity<T>
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        T Id { get; set; }
    }
}
