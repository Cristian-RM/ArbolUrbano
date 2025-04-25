using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TropicosSyncLib.Models
{
    /// <summary>
    /// Represents a local species-country relationship entity.
    /// </summary>
    public class LocalSpeciesCountry
    {
        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the species identifier.
        /// </summary>
        public int? SpeciesId { get; set; }

        /// <summary>
        /// Gets or sets the country identifier.
        /// </summary>
        public int? CountryId { get; set; }

        /// <summary>
        /// Gets or sets the creation date and time.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the last updated date and time.
        /// </summary>
        public DateTime UpdatedAt { get; set; }
    }
}
