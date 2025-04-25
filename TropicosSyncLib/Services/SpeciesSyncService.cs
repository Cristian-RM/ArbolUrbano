using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TropicosSyncLib.Data;
using TropicosSyncLib.Models;

namespace TropicosSyncLib.Services
{
    public class SpeciesSyncService : ISpeciesSyncService
    {
        private readonly ITropicosApiClient _tropicosApiClient;
        private readonly ISpeciesRepository _speciesRepository;

        public SpeciesSyncService(ITropicosApiClient tropicosApiClient, ISpeciesRepository speciesRepository)
        {
            _tropicosApiClient = tropicosApiClient;
            _speciesRepository = speciesRepository;
        }

        public async Task SyncSpeciesAsync(string name)
        {
            // Obtén especies desde Tropicos
            var speciesFromTropicos = await _tropicosApiClient.GetSpeciesAsync(name);

            foreach (var species in speciesFromTropicos)
            {
                // Aquí detectas si la especie ya existe en la DB o no
                var existingSpecies = await _speciesRepository.GetSpeciesByScientificNameAsync(species.ScientificName);
                if (existingSpecies == null)
                {
                    // Si no existe, lo agregas
                    var localSpecies = new LocalSpecies
                    {
                        ScientificName = species.ScientificName,
                        CommonName = species.CommonName,
                        Family = species.Family
                    };
                    await _speciesRepository.AddSpeciesAsync(localSpecies);
                }
                else
                {
                    // Si existe, actualizas si es necesario
                    existingSpecies.CommonName = species.CommonName;
                    existingSpecies.Family = species.Family;
                    await _speciesRepository.UpdateSpeciesAsync(existingSpecies);
                }
            }
        }
    }
}
