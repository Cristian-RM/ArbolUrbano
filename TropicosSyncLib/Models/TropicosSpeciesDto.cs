using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TropicosSyncLib.Models
{
    public class TropicosSpeciesDto
    {
        public string ScientificName { get; set; }
        public string CommonName { get; set; }
        public string Family { get; set; }
        // Otros campos según la respuesta de Tropicos
    }
}
