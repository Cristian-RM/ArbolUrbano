using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TropicosSyncLib.Models;

namespace TropicosSyncLib.Data
{
    public class SpeciesRepository : ISpeciesRepository
    {
        private readonly IDbContext _context;

        public SpeciesRepository(IDbContext context)
        {
            _context = context;
        }

        public async Task<LocalSpecies> GetSpeciesByScientificNameAsync(string scientificName)
        {
            // Accedemos a LocalSpecies de manera genérica
            return await _context.Set<LocalSpecies>().FirstOrDefaultAsync(s => s.ScientificName == scientificName) ?? new LocalSpecies();
        }

        public async Task AddSpeciesAsync(LocalSpecies species)
        {
            // Agregar una nueva especie
            await _context.Set<LocalSpecies>().AddAsync(species);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSpeciesAsync(LocalSpecies species)
        {
            // Actualizar una especie existente
            _context.Set<LocalSpecies>().Update(species);
            await _context.SaveChangesAsync();
        }
    }
}
