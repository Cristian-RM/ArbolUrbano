using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TropicosSyncLib.Models
{
    /// <summary>
    /// Represents a local species entity with additional taxonomic information.
    /// </summary>
    public class LocalSpecies
    {
        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the reference species identifier.
        /// </summary>
        public int SpeciesRefId { get; set; }

        /// <summary>
        /// Gets or sets the scientific name of the species.
        /// </summary>
        public string ScientificName { get; set; }

        /// <summary>
        /// Gets or sets the genus of the species.
        /// </summary>
        public string Genus { get; set; }

        /// <summary>
        /// Gets or sets the epithet of the species.
        /// </summary>
        public string Epithet { get; set; }

        /// <summary>
        /// Gets or sets the author who described the species.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the family identifier.
        /// </summary>
        public int? FamilyId { get; set; }

        /// <summary>
        /// Gets or sets the Tropicos identifier.
        /// </summary>
        public long? TropicosId { get; set; }

        /// <summary>
        /// Gets or sets the Wordflora identifier.
        /// </summary>
        public long? WordfloraId { get; set; }

        /// <summary>
        /// Gets or sets the last update date.
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// Gets or sets the person responsible for the species record.
        /// </summary>
        public string Responsible { get; set; }

        /// <summary>
        /// Gets or sets additional observations or notes about the species.
        /// </summary>
        public string Observations { get; set; }
    }
}
