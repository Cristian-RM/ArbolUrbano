using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TropicosSyncLib.Models
{
    /// <summary>
    /// Represents the local characteristics associated with a taxonomic entity.
    /// </summary>
    public class LocalCaracteristics
    {
        /// <summary>
        /// Gets or sets the unique identifier for the characteristic.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the characteristic.
        /// </summary>
        public string FeatureName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the data type of the characteristic (e.g., text, number).
        /// </summary>
        public string? DataType { get; set; }
    }
}
