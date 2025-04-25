using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TropicosSyncLib.Models;

namespace TropicosSyncLib.Services
{
    public interface ITropicosApiClient
    {
        Task<List<TropicosSpeciesDto>> GetSpeciesAsync(string name);
    }
}
