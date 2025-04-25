using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TropicosSyncLib.Models
{
    using System;

    /// <summary>
    /// Represents a local species characteristic entity.
    /// </summary>
    public class LocalSpeciesCharacteristic
    {
        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the species identifier.
        /// </summary>
        public int SpeciesId { get; set; }

        /// <summary>
        /// Gets or sets the characteristic identifier.
        /// </summary>
        public int CharacteristicId { get; set; }

        /// <summary>
        /// Gets or sets the integer value of the characteristic.
        /// </summary>
        public int? IntValue { get; set; }

        /// <summary>
        /// Gets or sets the decimal value of the characteristic.
        /// </summary>
        public decimal? DecimalValue { get; set; }

        /// <summary>
        /// Gets or sets the string value of the characteristic.
        /// </summary>
        public string StringValue { get; set; }

        /// <summary>
        /// Gets or sets the minimum range value of the characteristic.
        /// </summary>
        public decimal? MinRangeValue { get; set; }

        /// <summary>
        /// Gets or sets the maximum range value of the characteristic.
        /// </summary>
        public decimal? MaxRangeValue { get; set; }

        /// <summary>
        /// Gets or sets the description of the characteristic.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the creation date and time.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the last updated date and time.
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets the value of the characteristic based on its type.
        /// </summary>
        /// <returns>The value of the characteristic.</returns>
        public object GetCharacteristicValue()
        {
            if (IntValue.HasValue)
            {
                return IntValue.Value;
            }
            else if (DecimalValue.HasValue)
            {
                return DecimalValue.Value;
            }
            else if (!string.IsNullOrEmpty(StringValue))
            {
                return StringValue;
            }
            else if (MinRangeValue.HasValue && MaxRangeValue.HasValue)
            {
                return new { MinRangeValue, MaxRangeValue };
            }

            return null; // No value found
        }
    }
}