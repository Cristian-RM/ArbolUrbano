using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TropicosSyncLib.Models;

namespace TropicosSyncLib.Data
{
    public interface ISpeciesRepository
    {
        Task<LocalSpecies> GetSpeciesByScientificNameAsync(string scientificName);
        Task AddSpeciesAsync(LocalSpecies species);
        Task UpdateSpeciesAsync(LocalSpecies species);
    }
}
