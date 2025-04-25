using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TropicosSyncLib.Services
{
    public interface ISpeciesSyncService
    {
        Task SyncSpeciesAsync(string name);
    }
}
